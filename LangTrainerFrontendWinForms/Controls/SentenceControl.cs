

using LangTrainerEntity.Entities.Lang;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class SentenceControl : UserControl
    {
        public SentenceControl()
        {
            InitializeComponent();
        }

        public void Init(Expression expr)
        {
            _lang.Text = expr.Language.Name;
            _text.Text = expr.Text;
        }

    }
}
