
using LangTrainerClientModel.Services;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.WordList
{
    public partial class WordListControl : UserControl
    {

        public WordListControl()
        {
            InitializeComponent();
        }

        public void Init()
        {
            _searchControl.Changed += SearchControlOnTextChanged;
            Task.Run(RunSeach);
        }

        private async void SearchControlOnTextChanged(object? sender, SearchStringChangedEventArgs e)
        {
            await RunSeach();
        }

        private async Task RunSeach()
        {
            //_prServ.Switch(true);

            if (LangFilterService.GetInstance().IsLoaded)
            {
                var filterData = LangFilterService.GetInstance().Filter;
                await GetDataAndShow(_searchControl.SearchString, filterData.LangId, filterData.TrLangId);
            }
            else
            {
                LangFilterService.GetInstance().Loaded += async (sender, args) =>
                {
                    var filterData = LangFilterService.GetInstance().Filter;
                    await GetDataAndShow(_searchControl.SearchString, filterData.LangId, filterData.TrLangId);
                };
            }
        }

        private async Task GetDataAndShow(string str, Guid? langId, Guid? trLangId)
        {
            try
            {
                var res = await WordListService.GetInstance().GetList(str, langId);
                ShowData(res);
                //_prServ.Switch(false);
            }
            catch (Exception ex)
            {
                NotifyService.GetInstance().ShowMessage(ex.Message);
            }
        }

        private void ShowData(IEnumerable<WordListItem> items)
        {
            Invoke(() =>
            {
                _itemsTableLayout.SuspendLayout();
                _itemsTableLayout.Controls.Clear();
                if (items != null || items.Any())
                {
                    var i = 0;
                    _itemsTableLayout.RowStyles.Clear();

                    foreach (var item in items)
                    {
                        var ctr = new WordListItemControl();
                        ctr.Dock = DockStyle.Fill;
                        _itemsTableLayout.Controls.Add(ctr);
                        _itemsTableLayout.RowStyles.Add(new RowStyle()
                        {
                            Height = 50,
                            SizeType = SizeType.Absolute
                        });
                        _itemsTableLayout.SetRow(ctr, i++);
                        ctr.Init(item);
                    }
                    _itemsTableLayout.RowStyles.Add(new RowStyle()
                    {
                        Height = 100,
                        SizeType = SizeType.Percent
                    });
                }
                _itemsTableLayout.ResumeLayout();
            });

        }

    }
}
