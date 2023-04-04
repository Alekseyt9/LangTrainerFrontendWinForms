
using LangTrainerClientModel.Services;
using LangTrainerFrontendWinForms.Services.Controls;

namespace LangTrainerFrontendWinForms.Controls.WordList
{
    public partial class WordListItemControl : UserControl
    {
        private WordSoundsManager _sndMan;

        public WordListItemControl()
        {
            InitializeComponent();
        }

        public void Init(WordListItem item)
        {
            _labelWord.Text = item.Word;
            _labelTranslate.Text = item.Translate;
            _labelSample.Text = item.Sample;

            _sndMan = new WordSoundsManager(item.Sounds);
        }

        private void _buttonSound_Click(object sender, EventArgs e)
        {
            _sndMan.PlayNext();
        }

    }
}
