


using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.Login
{
    public partial class LoginControl : UserControl
    {
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

        private void loginButtonClick(object sender, EventArgs e)
        {
            try
            {
                UserService.GetInstance().Login(_loginText.Text, _passwordText.Text);
            }
            catch (Exception ex)
            {
                NotifyService.GetInstance().ShowMessage(ex.Message, 0.7f);
            }
        }

    }
}
