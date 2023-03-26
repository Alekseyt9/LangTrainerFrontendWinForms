
using LangTrainerClientModel.Services.LangService;
using LangTrainerFrontendWinForms.Services;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class WordInDictionaryItemControl : UserControl
    {
        public EventHandler<EventArgs> OnAddWordClick;

        private FindItemSound[] _sounds;
        private int _soundIndex;

        public WordInDictionaryItemControl()
        {
            InitializeComponent();
        }

        public void Init(FindItem item)
        {
            _wordText.Text = item.Expression;
            _sounds = item.Sounds.ToArray();

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
            var sound = _sounds[_soundIndex];
            _soundIndex = (_soundIndex + 1) % _sounds.Length;
            SoundService.GetInstance().Play(Convert.FromBase64String(sound.Data));
        }

    }
}
