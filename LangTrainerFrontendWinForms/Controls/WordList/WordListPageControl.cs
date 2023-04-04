
using LangTrainerFrontendWinForms.Model;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.WordList
{
    public partial class WordListPageControl : UserControl, ISettingsСonsumer
    {
        public WordListPageControl()
        {
            InitializeComponent();
        }

        public void Init()
        {
            trainingStartShort1.StartClick += TrainingStartShort1_StartClick;
            _wordListControl.Init();
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
