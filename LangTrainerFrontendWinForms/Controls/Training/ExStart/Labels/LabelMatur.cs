

using LangTrainerFrontendWinForms.Helpers;

namespace LangTrainerFrontendWinForms.Controls.Training.ExStart.Labels
{
    public partial class LabelMatur : UserControl
    {
        public EventHandler<EventArgs> OnCtrClick;

        public LabelMatur()
        {
            InitializeComponent();

            foreach (Control ctr in Controls)
            {
                ctr.DoRecurs(x => x.MouseDown += CtrMouseDown);
            }
        }

        private void CtrMouseDown(object? sender, MouseEventArgs e)
        {
            OnCtrClick(this, EventArgs.Empty);
        }

    }
}
