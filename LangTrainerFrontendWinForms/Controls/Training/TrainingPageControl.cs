
using LangTrainerFrontendWinForms.Controls.Training.ExStart;

namespace LangTrainerFrontendWinForms.Controls.Training
{
    public partial class TrainingPageControl : UserControl
    {
        public TrainingPageControl()
        {
            InitializeComponent();

            _tabPanel.Add("start", new ExStartControl());
            _tabPanel.Navigate("start");
        }

    }
}
