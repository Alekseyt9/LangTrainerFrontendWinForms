

using LangTrainerFrontendWinForms.Services;
using LangTrainerServices.Helpers;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class SoundButton : UserControl
    {
        public SoundButton()
        {
            InitializeComponent();
        }

        public byte[] Sound { get; set; }

        private void buttonClick(object sender, EventArgs e)
        {
            if (Sound == null)
                return;
            SoundService.GetInstance().Play(Sound);
        }

    }
}
