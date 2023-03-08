
using LangTrainerFrontendWinForms.Controls.Dictionary.Items;
using LangTrainerFrontendWinForms.Service;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class WordNotFoundItemControl : UserControl
    {
        public EventHandler<OnLoadWordEventArgs> OnLoadWordClick;

        public WordNotFoundItemControl()
        {
            InitializeComponent();

            var langs = LangService.GetInstance().GetLanguages().Result;
            foreach (var lang in langs)
            {
                _languageCombo.Items.Add(new ComboboxItem()
                {
                    Text = lang.Name,
                    Value = lang.Id
                });
            }
        }

        public void Init(string str)
        {
            _label.Text = $"Word '{str}' not found in database, try load the word from sites";
        }

        private void loadButtonClick(object sender, EventArgs e)
        {
            if (OnLoadWordClick != null)
            {
                var item = (ComboboxItem)_languageCombo.Items[_languageCombo.SelectedIndex];
                OnLoadWordClick(this, new OnLoadWordEventArgs()
                {
                    LanguageId = (Guid)item.Value
                });
            }
        }

    }
}
