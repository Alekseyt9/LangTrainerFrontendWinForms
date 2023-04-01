
using LangTrainerFrontendWinForms.Controls.Training.ExStart;

namespace LangTrainerFrontendWinForms.Controls.Training
{
    public partial class TrainingControl2 : UserControl
    {
        public TrainingControl2()
        {
            InitializeComponent();

            _tabPanel.Add("start", new ExStartControl());
            _tabPanel.Navigate("start");
        }

    }
}
