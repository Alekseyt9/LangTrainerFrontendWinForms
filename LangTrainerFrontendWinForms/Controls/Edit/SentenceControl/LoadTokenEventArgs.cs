
using LangTrainerClientModel.Services;

namespace LangTrainerFrontendWinForms.Controls.Edit.SentenceControl
{
    public class LoadTokenEventArgs : EventArgs
    {
        public WordInfo wordInfo { get; set; }
    }
}
