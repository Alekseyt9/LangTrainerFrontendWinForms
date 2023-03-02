

using LangTrainerFrontendWinForms.Helpers;

namespace LangTrainerFrontendWinForms.Controls.Training.ExStart.Labels
{
    public partial class LabelNew : UserControl
    {
        public EventHandler<EventArgs> OnCtrClick;

        public LabelNew()
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
