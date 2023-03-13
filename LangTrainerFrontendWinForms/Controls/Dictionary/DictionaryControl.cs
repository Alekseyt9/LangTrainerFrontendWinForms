
using LangTrainerClientModel.Services;
using LangTrainerFrontendWinForms.Controls.Dictionary;
using LangTrainerFrontendWinForms.Controls.Dictionary.Items;
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Service;
using LangTrainerFrontendWinForms.Services;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class DictionaryControl : UserControl
    {
        private readonly ProgressService _prServ;

        private Guid? _initialFilterLangId;
        private Guid? _initialFilterTrLangId;

        public DictionaryControl()
        {
            InitializeComponent();
            _prServ = new ProgressService(_progressBar);
        }

        public void Init()
        {
            AsyncHelper.DoAsync(_langFilterCombo, () =>
                {
                    var res = LangService.GetInstance().GetLanguages().Result;
                    return res;
                },
                (ctr, data) =>
                {
                    if (data == null)
                    {
                        return;
                    }
                    Invoke(() =>
                    {
                        ctr.Items.Clear();
                        foreach (var item in data)
                        {
                            ctr.Items.Add(new ComboboxItem()
                            {
                                Text = item.Name,
                                Value = item.Id
                            });
                        }
                        InitFilters();
                    });
                }
            );

            AsyncHelper.DoAsync(_trLangFilterCombo, () =>
                {
                    var res = LangService.GetInstance().GetTranslateLanguages().Result;
                    return res;
                },
                (ctr, data) =>
                {
                    if (data == null)
                    {
                        return;
                    }
                    Invoke(() =>
                    {
                        ctr.Items.Clear();
                        foreach (var item in data)
                        {
                            ctr.Items.Add(new ComboboxItem()
                            {
                                Text = item.Name,
                                Value = item.Id
                            });
                        }
                        InitFilters();
                    });
                }
            );
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
                    ctr.Init(data.SearchString);
                    _itemsTableLayout.Controls.Add(ctr);
                    ctr.OnLoadWordClick += OnLoadWordClick;
                }
                else
                {
                    var i = 0;
                    foreach (var item in data.Items)
                    {
                        var ctr = new AddWordItemControl();
                        ctr.Dock = DockStyle.Fill;
                        ctr.Init(item);
                        _itemsTableLayout.Controls.Add(ctr);
                        _itemsTableLayout.SetRow(ctr, i++);
                    }
                }
            });
        }

        private async void OnLoadWordClick(object? sender, OnLoadWordEventArgs e)
        {
            if (!string.IsNullOrEmpty(_searchText.Text))
            {
                _prServ.Switch(true);

                var langServ = LangService.GetInstance();
                var res = await langServ.LoadInBase(
                    new WordInfo(_searchText.Text, e.LanguageId));
                if (res.WordFound)
                {
                    NotifyService.GetInstance().ShowMessage("Word found");
                    await GetDataAndShow(_searchText.Text);
                }
                else
                {
                    NotifyService.GetInstance().ShowMessage("Word not found");
                    _prServ.Switch(false);
                }
            }
        }

        private async Task GetDataAndShow(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    var langServ = LangService.GetInstance();
                    var res = await langServ.FindInDictionary(str, null, null);
                    ShowData(res);
                    _prServ.Switch(false);
                }
                catch (Exception ex)
                {
                    NotifyService.GetInstance().ShowMessage(ex.Message);
                }
            }
        }

        private async void searchTextTextChanged(object sender, EventArgs e)
        {
            _prServ.Switch(true);

            await GetDataAndShow(_searchText.Text);
        }

        private void clearButtonClick(object sender, EventArgs e)
        {
            _itemsTableLayout.Controls.Clear();
            _searchText.Text = null;
        }

        public void InitSettings(Settings settings)
        {
            _initialFilterLangId = settings.Get<Guid?>(SettingsKeys.DictionaryFilterLangId);
            _initialFilterTrLangId = settings.Get<Guid?>(SettingsKeys.DictionaryFilterTrLangId);
            InitFilters();
        }

        private void InitFilters()
        {
            if (_initialFilterLangId.HasValue && _langFilterCombo.Items.Count > 0)
            {
                var item = _langFilterCombo.Items.Cast<ComboboxItem>()
                    .First(x => (Guid)x.Value == _initialFilterLangId);
                _langFilterCombo.SelectedItem = item;
            }

            if (_initialFilterTrLangId.HasValue && _trLangFilterCombo.Items.Count > 0)
            {
                var item = _trLangFilterCombo.Items.Cast<ComboboxItem>()
                    .First(x => (Guid)x.Value == _initialFilterTrLangId);
                _trLangFilterCombo.SelectedItem = item;
            }
        }

        public void SaveSettings(Settings settings)
        {
            if (_langFilterCombo.SelectedItem != null)
            {
                var item = (ComboboxItem)_langFilterCombo.SelectedItem;
                settings.Set(SettingsKeys.DictionaryFilterLangId, item.Value);
            }

            if (_trLangFilterCombo.SelectedItem != null)
            {
                var item = (ComboboxItem)_trLangFilterCombo.SelectedItem;
                settings.Set(SettingsKeys.DictionaryFilterTrLangId, item.Value);
            }
        }

    }
}
