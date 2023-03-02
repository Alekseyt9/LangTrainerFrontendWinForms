
using LangTrainerClientModel.Services;

namespace LangTrainerFrontendWinForms.Controls.Edit.SentenceControl
{
    public class LoadTokenEventArgs : EventArgs
    {
        public TokenInfo tokenInfo { get; set; }
    }
}
