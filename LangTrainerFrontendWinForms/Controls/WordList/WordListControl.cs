
using LangTrainerFrontendWinForms.Model;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.WordList
{
    public partial class WordListControl : UserControl, ISettingsСonsumer
    {
        public WordListControl()
        {
            InitializeComponent();
        }

        public void Init()
        {
            //_langFilter.Init();
            var wl = new WordList() { AutoSize = true, Dock = DockStyle.Fill };
            //accordion1.Add(wl, "My dictionary", fillWt: 1, open: true);

            trainingStartShort1.StartClick += TrainingStartShort1_StartClick;
        }

        private void TrainingStartShort1_StartClick(object? sender, EventArgs e)
        {
            NavigateService.GetInstance().Navigate("trainerPage");
        }

        public void InitSettings(Settings settings, string parentKey)
        {
            //_langFilter.InitSettings(settings, parentKey);
        }

        public void SaveSettings(Settings settings, string parentKey)
        {
            //_langFilter.SaveSettings(settings, parentKey);
        }

    }
}
