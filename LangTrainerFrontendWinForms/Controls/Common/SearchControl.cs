

namespace LangTrainerFrontendWinForms.Controls.Common
{
    public partial class SearchControl : UserControl
    {
        public event EventHandler<SearchStringChangedEventArgs> Changed;
        public event EventHandler<EventArgs> Clear;

        public string SearchString => _searchText.Text;

        public SearchControl()
        {
            InitializeComponent();
        }

        private void _searchText_TextChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(this, new SearchStringChangedEventArgs()
            {
                SearchString = _searchText.Text
            });
        }

        private void _clearButton_Click(object sender, EventArgs e)
        {
            _searchText.Text = null;
            Clear?.Invoke(this, new EventArgs { });
        }

    }
}
