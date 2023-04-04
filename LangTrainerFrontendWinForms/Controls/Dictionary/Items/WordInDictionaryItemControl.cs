
using LangTrainerClientModel.Services;
using LangTrainerFrontendWinForms.Services;
using LangTrainerFrontendWinForms.Services.Controls;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class WordInDictionaryItemControl : UserControl
    {
        public EventHandler<EventArgs> OnAddWordClick;

        private WordSoundsManager _sndMan;

        public WordInDictionaryItemControl()
        {
            InitializeComponent();
        }

        public void Init(FindItem item)
        {
            _wordText.Text = item.Expression;
            _sndMan = new WordSoundsManager(item.Sounds.ToArray());

            _translateCombo.Items.Clear();
            foreach (var tr in item.Translates)
            {
                _translateCombo.Items.Add(new ComboboxItem()
                {
                    Text = tr.Text,
                    Value = tr.TranslateId
                });
            }
        }

        private async void _addButtonClick(object sender, EventArgs e)
        {
            if (_translateCombo.SelectedItem != null)
            {
                var item = (ComboboxItem)_translateCombo.SelectedItem;
                try
                {
                    await TrainingService.GetInstance().AddToTraining((Guid)item.Value);
                    NotifyService.GetInstance().ShowMessage("The word has been added to your list");
                }
                catch (Exception ex)
                {
                    NotifyService.GetInstance().ShowMessage(ex.Message);
                }
            }
            else
            {
                NotifyService.GetInstance().ShowMessage("Select translation");
            }
        }

        private void _soundButton_Click(object sender, EventArgs e)
        {
            _sndMan.PlayNext();
        }

    }
}
