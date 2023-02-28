
using LangTrainerEntity.Entities.Lang;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class SentenceEditControl : UserControl
    {
        //public Expression Expr { get; set; }
        public event EventHandler<SentenceEditEventArgs> OnFormResult;

        public SentenceEditControl()
        {
            InitializeComponent();
        }

        public void InitForm(Expression expr)
        {
            sentenceControl1.Init(expr);
            soundsControl1.Init(expr);
            translatesControl1.Init(expr);
            samplesControl1.Init(expr);
        }

    }
}
