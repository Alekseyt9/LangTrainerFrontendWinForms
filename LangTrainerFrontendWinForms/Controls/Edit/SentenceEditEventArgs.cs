

using LangTrainerEntity.Entities;

namespace LangTrainerFrontendWinForms.Controls.Edit
{
    public class SentenceEditEventArgs : EventArgs
    {
        Expression Expr { get; set; }

        DialogResult Result { get; set; }
    }
}
