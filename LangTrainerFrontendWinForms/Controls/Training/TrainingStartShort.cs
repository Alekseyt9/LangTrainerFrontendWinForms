

namespace LangTrainerFrontendWinForms.Controls.Training
{
    public partial class TrainingStartShort : UserControl
    {

        public event EventHandler StartClick;

        public TrainingStartShort()
        {
            InitializeComponent();
        }

        private void _startButton_Click(object sender, EventArgs e)
        {
            StartClick?.Invoke(this, EventArgs.Empty);
        }

    }
}
