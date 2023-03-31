
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.Login
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler<LoginResultEventArgs> OnLoginResult;

        public LoginControl()
        {
            InitializeComponent();

            _loginInternalControl.OnLoginResult += _loginInternalControl_OnLoginResult;
        }

        private void _loginInternalControl_OnLoginResult(object? sender, LoginResultEventArgs e)
        {
            OnLoginResult?.Invoke(this, e);
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

        public void InitSettings(Settings settings)
        {
            _loginInternalControl.InitSettings(settings, null);
        }

        public void SaveSettings(Settings settings)
        {
            _loginInternalControl.SaveSettings(settings, null);
        }

    }
}
