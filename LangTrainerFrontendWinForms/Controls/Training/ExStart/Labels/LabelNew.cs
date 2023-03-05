

using LangTrainerClientModel.Model;
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

        public void Init(StartTrainingItem model)
        {
            _labelHeader.Text = $"New words to learn ({model.Count})";
            if (model.Words != null)
            {
                _labelWords.Text = $"{string.Join(", ", model.Words)}";
            }
        }

    }
}
