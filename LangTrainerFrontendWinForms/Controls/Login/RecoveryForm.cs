

using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls.Login
{
    public partial class RecoveryForm : Form
    {
        public RecoveryForm()
        {
            InitializeComponent();
        }

        private async void _sendButton_Click(object sender, EventArgs e)
        {
            await AuthService.GetInstance().Recovery(_emailText.Text);
        }

    }
}
