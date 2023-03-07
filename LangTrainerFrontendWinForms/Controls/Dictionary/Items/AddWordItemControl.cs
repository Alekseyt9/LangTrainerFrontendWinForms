
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class AddWordItemControl : UserControl
    {
        public EventHandler<EventArgs> OnAddWordClick;

        public AddWordItemControl()
        {
            InitializeComponent();
        }

        public void Init(FindItem item)
        {
            _wordText.Text = item.Expression;

            _translateCombo.Items.Clear();
            foreach (var tr in item.Translates)
            {
                _translateCombo.Items.Add(new ComboboxItem()
                {
                    Text = tr.Text,
                    Value = tr.LanguageId
                });
            }
        }

        private void _addWordButtonClick(object sender, EventArgs e)
        {
            OnAddWordClick(this, EventArgs.Empty);
        }

    }
}
