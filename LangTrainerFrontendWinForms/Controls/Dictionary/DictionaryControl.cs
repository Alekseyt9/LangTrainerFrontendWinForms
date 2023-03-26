
using LangTrainerClientModel.Services;
using LangTrainerFrontendWinForms.Controls.Common;
using LangTrainerFrontendWinForms.Controls.Dictionary;
using LangTrainerFrontendWinForms.Controls.Dictionary.Items;
using LangTrainerFrontendWinForms.Model;
using LangTrainerFrontendWinForms.Service;
using LangTrainerFrontendWinForms.Services;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class DictionaryControl : UserControl, ISettingsСonsumer
    {
        private readonly ProgressService _prServ;

        public DictionaryControl()
        {
            InitializeComponent();
            _prServ = new ProgressService(_progressBar);
            _searchControl.Changed += SearchControlOnTextChanged;
            _langFilter.LangChanged += _langFilter_LangChanged;
        }

        private async void _langFilter_LangChanged(object? sender, EventArgs e)
        {
            await RunSeach();
        }

        private async Task RunSeach()
        {
            if (!string.IsNullOrEmpty(_searchControl.SearchString))
            {
                _prServ.Switch(true);
                var filterData = _langFilter.Data;
                await GetDataAndShow(_searchControl.SearchString, filterData.LangId, filterData.TrLangId);
            }
        }

        public void Init()
        {
            _langFilter.Init();
        }

        private async void SearchControlOnTextChanged(object? sender, SearchStringChangedEventArgs e)
        {
            await RunSeach();
        }

        private void ShowData(FindResult data)
        {
            Invoke(() =>
            {
                _itemsTableLayout.Controls.Clear();
                if (data.Items == null || data.Items.Count == 0)
                {
                    var ctr = new WordNotFoundItemControl();
                    ctr.Dock = DockStyle.Fill;
                    _itemsTableLayout.Controls.Add(ctr);
                    ctr.OnLoadWordClick += OnLoadWordClick;
                    ctr.Init(data.SearchString);
                }
                else
                {
                    var i = 0;
                    foreach (var item in data.Items)
                    {
                        var ctr = new WordInDictionaryItemControl();
                        ctr.Dock = DockStyle.Fill;
                        _itemsTableLayout.Controls.Add(ctr);
                        _itemsTableLayout.SetRow(ctr, i++);
                        ctr.Init(item);
                    }
                }
            });
        }

        private async void OnLoadWordClick(object? sender, OnLoadWordEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Word))
            {
                _prServ.Switch(true);

                var langServ = LangService.GetInstance();
                var res = await langServ.LoadInBase(
                    new WordInfo(e.Word, e.LanguageId));
                if (res.WordFound)
                {
                    NotifyService.GetInstance().ShowMessage("Word found");
                    var filterData = _langFilter.Data;
                    await GetDataAndShow(e.Word, filterData.LangId, filterData.TrLangId);
                }
                else
                {
                    NotifyService.GetInstance().ShowMessage("Word not found");
                    _prServ.Switch(false);
                }
            }
        }

        private async Task GetDataAndShow(string str, Guid? langId, Guid? trLangId)
        {
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    var langServ = LangService.GetInstance();
                    var res = await langServ.FindInDictionary(str, langId, trLangId);
                    ShowData(res);
                    _prServ.Switch(false);
                }
                catch (Exception ex)
                {
                    NotifyService.GetInstance().ShowMessage(ex.Message);
                }
            }
        }

        public void InitSettings(Settings settings, string parentKey)
        {
            _langFilter.InitSettings(settings, null);
        }

        public void SaveSettings(Settings settings, string parentKey)
        {
            _langFilter.SaveSettings(settings, null);
        }

    }
}
