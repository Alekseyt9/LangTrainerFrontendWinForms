
using LangTrainerClientModel.Services;

namespace LangTrainerFrontendWinForms.Controls.WordList
{
    public partial class WordListItemControl : UserControl
    {
        public WordListItemControl()
        {
            InitializeComponent();
        }

        public void Init(WordListItem item)
        {
            _labelWord.Text = item.Word;
            _labelTranslate.Text = item.Translate;
            _labelSample.Text = item.Sample;
        }

    }
}
