
using LangTrainerFrontendWinForms.Model;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.Login
{
    public partial class LoginInternalControl : UserControl, ISettingsСonsumer
    {
        public event EventHandler<LoginResultEventArgs> OnLoginResult;

        public LoginInternalControl()
        {
            InitializeComponent();
        }

        public void InitSettings(Settings settings, string parentKey)
        {
            _loginText.Text = settings.Get<string>(SettingsKeys.Login);
            EnsureFocus();
        }

        public void SaveSettings(Settings settings, string parentKey)
        {
            settings.Set(SettingsKeys.Login, _loginText.Text);
        }

        private async void loginButtonClick(object sender, EventArgs e)
        {
            await DoLogin();
        }

        private async Task DoLogin()
        {
            try
            {
                var res = await AuthService.GetInstance().Login(_loginText.Text, _passwordText.Text);
                if (OnLoginResult != null)
                {
                    OnLoginResult(this, new LoginResultEventArgs()
                    {
                        IsSuccess = res
                    });
                }
            }
            catch (Exception ex)
            {
                NotifyService.GetInstance().ShowMessage(ex.Message);
            }
        }

        private void _passMaskButton_Click(object sender, EventArgs e)
        {
            if (_passwordText.PasswordChar == '\0')
            {
                _passwordText.PasswordChar = '*';
            }
            else
            {
                _passwordText.PasswordChar = '\0';
            }
        }

        private async void FieldKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await DoLogin();
            }
        }

        private void EnsureFocus()
        {
            if (string.IsNullOrEmpty(_loginText.Text))
            {
                _loginText.Select();
            }
            else
            {
                _passwordText.Select();
            }
        }

    }
}
