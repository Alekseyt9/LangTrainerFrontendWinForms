
using LangTrainerFrontendWinForms.Controls.Dictionary.Items;
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Service;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class WordNotFoundItemControl : UserControl
    {
        private string _word;

        public EventHandler<OnLoadWordEventArgs> OnLoadWordClick;

        public WordNotFoundItemControl()
        {
            InitializeComponent();
        }

        public void Init(string str)
        {
            _word = str;
            _label.Text = $"Word '{_word}' not found in database";
        }

        private void loadButtonClick(object sender, EventArgs e)
        {
            var filter = LangFilterService.GetInstance().Filter;
            OnLoadWordClick?.Invoke(this, new OnLoadWordEventArgs()
            {
                LanguageId = filter.LangId.Value,
                Word = _word
            });
        }

    }
}
