

namespace LangTrainerFrontendWinForms.Controls.Training.ExStart
{
    public partial class ExStartControl : UserControl
    {
        public ExStartControl()
        {
            InitializeComponent();

            labelMatur1.OnCtrClick += (sender, args) => { MessageBox.Show("maturation"); };
            labelNew1.OnCtrClick += (sender, args) => { MessageBox.Show("new"); };
            labelRepeat1.OnCtrClick += (sender, args) => { MessageBox.Show("repeat"); };
        }

    }
}
