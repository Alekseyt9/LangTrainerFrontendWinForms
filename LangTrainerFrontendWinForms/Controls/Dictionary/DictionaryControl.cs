
using LangTrainerFrontendWinForms.Service;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class DictionaryControl : UserControl
    {
        public DictionaryControl()
        {
            InitializeComponent();
        }

        private void ShowData(FindResult data)
        {
            _itemsTableLayout.Controls.Clear();
            if (data.Items == null || data.Items.Count == 0)
            {
                var ctr = new WordNotFoundItemControl();
                ctr.Init(data.SearchString);
                _itemsTableLayout.Controls.Add(ctr);
            }
            else
            {
                var i = 0;
                foreach (var item in data.Items)
                {
                    var ctr = new AddWordItemControl();
                    ctr.Init(item);
                    _itemsTableLayout.Controls.Add(ctr);
                    _itemsTableLayout.SetRow(ctr, i++);
                }
            }

        }

        private async void _searchTextTextChanged(object sender, EventArgs e)
        {
            var langServ = LangService.GetInstance();
            var res = await langServ.FindInDictionary(_searchText.Text, null, null);
            ShowData(res);
        }

    }
}
