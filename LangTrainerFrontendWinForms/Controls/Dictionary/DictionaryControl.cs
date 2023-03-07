
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Service;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class DictionaryControl : UserControl
    {
        public DictionaryControl()
        {
            InitializeComponent();

            Init();
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

        private async void _searchTextTextChanged(object sender, EventArgs e)
        {
            var langServ = LangService.GetInstance();
            if (!string.IsNullOrEmpty(_searchText.Text))
            {
                var res = await langServ.FindInDictionary(_searchText.Text, null, null);
                ShowData(res);
            }
        }

        private void _clearButtonClick(object sender, EventArgs e)
        {
            _itemsTableLayout.Controls.Clear();
            _searchText.Text = null;
        }

    }
}
