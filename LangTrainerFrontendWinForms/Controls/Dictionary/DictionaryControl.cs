
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
        private ProgressService _prServ;

        public DictionaryControl()
        {
            InitializeComponent();
            Init();
            _prServ = new ProgressService(_progressBar);
        }

        private void Init()
        {
            AsyncHelper.DoAsync(_langFilterCombo, () =>
                {
                    var res = LangService.GetInstance().GetLanguages().Result;
                    return res;
                },
                (ctr, data) =>
                {
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
                    });
                }
            );
        }

        private void ShowData(FindResult data)
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
                var langServ = LangService.GetInstance();
                var res = await langServ.FindInDictionary(str, null, null);
                ShowData(res);
                _prServ.Switch(false);
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

    }
}
