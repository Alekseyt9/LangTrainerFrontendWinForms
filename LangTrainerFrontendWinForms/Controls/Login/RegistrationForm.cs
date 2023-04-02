
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.Login
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private async void _registerButton_Click(object sender, EventArgs e)
        {
            if (_passText.Text == _passRepText.Text)
            {
                try
                {
                    await AuthService.GetInstance().Register(_emailText.Text, _passText.Text);
                    NotifyService.GetInstance().ShowMessage("Registration success", this, _toolTip);
                    Close();
                }
                catch (Exception ex)
                {
                    NotifyService.GetInstance().ShowMessage(ex.Message, this, _toolTip);
                }
            }
        }

    }
}
