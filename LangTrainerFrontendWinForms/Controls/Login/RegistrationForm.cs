
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
                await AuthService.GetInstance().Register(_loginText.Text, _emailText.Text, _passText.Text);
            }
        }

    }
}
