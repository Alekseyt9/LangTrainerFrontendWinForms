

using LangTrainerEntity.Entities.Lang;

namespace LangTrainerFrontendWinForms.Controls
{
    public class SentenceEditEventArgs : EventArgs
    {
        Expression Expr { get; set; }

        DialogResult Result { get; set; }
    }
}
