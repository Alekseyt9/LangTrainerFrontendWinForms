


using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.Login
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler<LoginResultEventArgs> OnLoginResult; 

        public LoginControl()
        {
            InitializeComponent();
        }

        private void passRecoverLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new RecoveryForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void registrationLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new RegistrationForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private async void loginButtonClick(object sender, EventArgs e)
        {
            try
            {
                var res = await UserService.GetInstance().Login(_loginText.Text, _passwordText.Text);
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
                NotifyService.GetInstance().ShowMessage(ex.Message, 0.7f);
            }
        }

        public void InitSettings(Settings settings)
        {
            _loginText.Text = settings.Get<string>(SettingsKeys.Login);
        }

        public void SaveSettings(Settings settings)
        {
            settings.Set(SettingsKeys.Login, _loginText.Text);
        }

    }
}
