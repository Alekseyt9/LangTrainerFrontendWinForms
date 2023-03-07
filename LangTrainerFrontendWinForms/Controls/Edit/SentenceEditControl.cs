
using LangTrainerEntity.Entities;
using LangTrainerFrontendWinForms.Controls.Edit;
using LangTrainerFrontendWinForms.Controls.Edit.SentenceControl;
using LangTrainerFrontendWinForms.Service;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class SentenceEditControl : UserControl
    {
        public event EventHandler<SentenceEditEventArgs> OnFormResult;

        public SentenceEditControl()
        {
            InitializeComponent();
            sentenceControl1.OnLoadToken += SentenceControl1_OnLoadToken;
        }

        public void InitForm(Expression expr)
        {
            sentenceControl1.Init(expr);
            soundsControl1.Init(expr);
            translatesControl1.Init(expr);
            samplesControl1.Init(expr);
        }

        private async void SentenceControl1_OnLoadToken(object? sender, LoadTokenEventArgs e)
        {
            var serv = LangService.GetInstance();
            var expr = await serv.GetTokenData(e.tokenInfo.Expression, e.tokenInfo.Language);
            InitForm(expr);
        }

    }
}
