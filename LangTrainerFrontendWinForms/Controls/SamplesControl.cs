

using LangTrainerEntity.Entities.Lang;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class SamplesControl : UserControl
    {
        public SamplesControl()
        {
            InitializeComponent();
        }

        public void Init(Expression expr)
        {
            _listBox.Items.Clear();
            foreach (var tr in expr.Samples)
            {
                _listBox.Items.Add($"{tr.Text}");
            }
        }

    }
}
