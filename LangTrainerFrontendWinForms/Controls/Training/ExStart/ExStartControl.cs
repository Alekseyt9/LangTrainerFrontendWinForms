
using LangTrainerClientModel.Services;

namespace LangTrainerFrontendWinForms.Controls.Training.ExStart
{
    public partial class ExStartControl : UserControl
    {
        public ExStartControl()
        {
            InitializeComponent();

            _labelMatur.OnCtrClick += (sender, args) => { MessageBox.Show("maturation"); };
            _labelNew.OnCtrClick += (sender, args) => { MessageBox.Show("new"); };
            _labelRepeat.OnCtrClick += (sender, args) => { MessageBox.Show("repeat"); };
        }

        public void Init(StartTrainingModel model)
        {
            _labelMatur.Init(model.Maturation);
            _labelNew.Init(model.New);
            _labelRepeat.Init(model.Repeat);
        }

    }
}
