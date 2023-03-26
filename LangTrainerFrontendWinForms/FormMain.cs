
using LangTrainerClientModel.Model;
using LangTrainerClientModel.Model.Training;
using LangTrainerFrontendWinForms.Controls.Training.ExStart;
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms
{
    public partial class FormMain : Form
    {
        private Settings _localSettings;
        private Settings _remoteSettings;

        public FormMain()
        {
            InitializeComponent();

            LoadLocalSettings();
            NotifyService.GetInstance().Init(this, toolTip1);

            Load += FormMainLoad;
            KeyPreview = true;
            KeyDown += FormMainKeyDown;
            FormClosing += OnFormClosing;

            _tabControl.HideHeader();
            NavigateService.GetInstance().Init(_tabControl);
            NavigateService.GetInstance().Navigate("loginPage");

            LoginEnabled(false);
            _loginControl.OnLoginResult += loginControlOnLoginResult;
        }

        private async void loginControlOnLoginResult(object? sender, Controls.Login.LoginResultEventArgs e)
        {
            if (e.IsSuccess)
            {
                await LoadRemoteSettings();
                LoginEnabled(true);
                NavigateService.GetInstance().Navigate("dictionaryPage");

                _dictionaryControl.Init();
                _dictionaryControl.InitSettings(_remoteSettings, "dictionary");

                _wordListControl.Init();
                _wordListControl.InitSettings(_remoteSettings, "wordList");
            }
        }

        private async Task LoadRemoteSettings()
        {
            _remoteSettings = await SettingsService.GetInstance().GetRemoteSettings();
        }

        private void LoginEnabled(bool flag)
        {
            menuStrip1.Enabled = flag;
        }

        private void LoadLocalSettings()
        {
            _localSettings = SettingsService.GetInstance().GetLocalSettings();
            _loginControl.InitSettings(_localSettings);
        }

        private async Task SaveSettings()
        {
            if (_localSettings != null)
            {
                _loginControl.SaveSettings(_localSettings);
                SettingsService.GetInstance().SaveLocalSettings(_localSettings);
            }

            if (_remoteSettings != null)
            {
                _dictionaryControl.SaveSettings(_remoteSettings, "dictionary");
                _wordListControl.SaveSettings(_remoteSettings, "wordList");
                await SettingsService.GetInstance().SaveRemoteSettings(_remoteSettings);
            }
        }

        private void FormMainKeyDown(object? sender, KeyEventArgs e)
        {

        }

        private async void FormMainLoad(object? sender, EventArgs e)
        {
            TrainerTest();
        }

        /*
        private async Task InitEditFormTest()
        {
            var serv = new LangService();
            var expr = await serv.GetTokenData("data", "english");
            sentenceEditControl1.InitForm(expr);
        }
        */

        private void TrainerTest()
        {
            InitStartPage();
            InitExs();
        }

        private void InitExs()
        {
            /*
            var model = GetTrainingModel();
            var ctr = new MainController(tabControl1, model);
            ctr.Next();
            */
        }

        private void InitStartPage()
        {
            var model = new StartTrainingModel()
            {
                Maturation = new StartTrainingItem()
                {
                    Count = 111,
                    Words = new List<string>() { "aaa", "bbb" }
                },
                New = new StartTrainingItem()
                {
                    Count = 222,
                    Words = new List<string>() { "ggg", "hhh" }
                },
                Repeat = new StartTrainingItem()
                {
                    Count = 333,
                    Words = new List<string>() { "ooo", "ppp" }
                },
            };

            var startTrCtr = this.Find<ExStartControl>().First();
            startTrCtr.Init(model);
        }

        private TrainingModel GetTrainingModel()
        {
            return new TrainingModel()
            {
                Model1 = new Excercize1Model()
                {
                    Answer = "lure",
                    Question = "the quality or power that something or someone has that makes it, him, or her attractive",
                    Variants = new[] { "lurk", "bury", "litter", "lure" }
                }
            };
        }

        private void DictionaryMenuItemClick(object sender, EventArgs e)
        {
            NavigateService.GetInstance().Navigate("dictionaryPage");
        }

        private void TrainingMenuItemClick(object sender, EventArgs e)
        {
            NavigateService.GetInstance().Navigate("trainerPage");
        }

        private void TasksMenuItem1Click(object sender, EventArgs e)
        {
            NavigateService.GetInstance().Navigate("taskPage");
        }

        private void wordListMenuItem_Click(object sender, EventArgs e)
        {
            NavigateService.GetInstance().Navigate("wordListPage");
        }

        private async void OnFormClosing(object? sender, FormClosingEventArgs e)
        {
            await SaveSettings();
        }

    }
}