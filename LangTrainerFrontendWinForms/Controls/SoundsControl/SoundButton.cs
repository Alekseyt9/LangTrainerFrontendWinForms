

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
            var ss = new SoundService();
            if (Sound == null)
                return;
            ss.Play(Sound);
        }

    }
}
