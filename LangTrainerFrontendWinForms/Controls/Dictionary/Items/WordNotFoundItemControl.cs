
namespace LangTrainerFrontendWinForms.Controls.Dictionary.Items
{
    public partial class WordNotFoundItemControl : UserControl
    {
        public EventHandler<EventArgs> OnLoadWordClick;

        public WordNotFoundItemControl()
        {
            InitializeComponent();
        }

        public void Init(string str)
        {
            _label.Text = $"Word '{str}' not found in database, try load the word from sites";
        }

        private void _loadButtonClick(object sender, EventArgs e)
        {
            OnLoadWordClick(this, EventArgs.Empty);
        }

    }
}
