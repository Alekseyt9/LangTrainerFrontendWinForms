
using LangTrainerFrontendWinForms.Controls;
using LangTrainerFrontendWinForms.Controls.Login;
using LangTrainerFrontendWinForms.Controls.Training;
using LangTrainerFrontendWinForms.Controls.WordList;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms
{
    public partial class MainForm2 : Form
    {
        private Settings _localSettings;
        private Settings _remoteSettings;

        private readonly LoginControl _loginControl;
        private readonly TrainingControl2 _trainingControl;
        private readonly DictionaryControl _dictionaryControl;
        private readonly WordListControl _wordListControl;

        public MainForm2()
        {
            InitializeComponent();

            _loginControl = new LoginControl();
            _trainingControl = new TrainingControl2();
            _dictionaryControl = new DictionaryControl();
            _wordListControl = new WordListControl();

            _tabPanel.Add("loginPage", _loginControl);
            _tabPanel.Add("trainerPage", _trainingControl);
            _tabPanel.Add("dictionaryPage", _dictionaryControl);
            _tabPanel.Add("wordListPage", _wordListControl);

            NavigateService.GetInstance().Init(_tabPanel);
            NavigateService.GetInstance().Navigate("loginPage");
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            _mainMenuStrip.Visible = false;
            LoadLocalSettings();
            NotifyService.GetInstance().Init(this, _toolTip);

            KeyPreview = true;
            FormClosing += OnFormClosing;

            LoginEnabled(false);
            _loginControl.OnLoginResult += loginControlOnLoginResult;
        }

        private async void loginControlOnLoginResult(object? sender, LoginResultEventArgs e)
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

                _mainMenuStrip.Visible = true;

                LangFilterService.GetInstance().InitSettings(_remoteSettings, null);
                LangFilterService.GetInstance().Init(this, optionsToolStripMenuItem);
            }
        }

        private async Task LoadRemoteSettings()
        {
            _remoteSettings = await SettingsService.GetInstance().GetRemoteSettings();
        }

        private void LoginEnabled(bool flag)
        {
            _mainMenuStrip.Enabled = flag;
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
                LangFilterService.GetInstance().SaveSettings(_remoteSettings, null);
                await SettingsService.GetInstance().SaveRemoteSettings(_remoteSettings);
            }
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
            _tabPanel.Navigate("taskPage");
        }

        private void wordListMenuItem_Click(object sender, EventArgs e)
        {
            NavigateService.GetInstance().Navigate("wordListPage");
        }

        private async void OnFormClosing(object? sender, FormClosingEventArgs e)
        {
            await SaveSettings();
        }

        private void langFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
