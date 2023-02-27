
using LangTrainerFrontendWinForms.Services;
using LangTrainerServices.Helpers;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class SoundsControl : UserControl
    {
        public SoundsControl()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var ss = new SoundService();
            var stream = File.Open(@"../../../Sounds/test.mp3", FileMode.Open, FileAccess.Read);
            ss.Play(stream.ToBytes());
        }

    }
}
