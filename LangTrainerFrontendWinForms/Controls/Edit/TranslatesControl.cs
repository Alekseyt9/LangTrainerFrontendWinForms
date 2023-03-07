
using LangTrainerEntity.Entities;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class TranslatesControl : UserControl
    {
        public TranslatesControl()
        {
            InitializeComponent();
        }

        public void Init(Expression expr)
        {
            _listBox.Items.Clear();
            foreach (var tr in expr.Translates)
            {
                _listBox.Items.Add($"{tr.Text} [{tr.Language.Name}]");
            }
        }

    }
}
