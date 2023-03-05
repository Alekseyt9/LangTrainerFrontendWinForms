

using LangTrainerClientModel.Model;
using LangTrainerFrontendWinForms.Helpers;

namespace LangTrainerFrontendWinForms.Controls.Training.ExStart.Labels
{
    public partial class LabelRepeat : UserControl
    {
        public EventHandler<EventArgs> OnCtrClick;

        public LabelRepeat()
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

        public void Init(StartTrainingItem model)
        {
            _labelHeader.Text = $"{model.Count} words urgently repeat";
            if (model.Words != null)
            {
                _labelWords.Text = $"{string.Join(", ", model.Words)}";
            }
        }

    }
}
