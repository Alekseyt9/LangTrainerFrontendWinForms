

using LangTrainerClientModel.Services;
using LangTrainerEntity.Entities.Lang;
using LangTrainerFrontendWinForms.Controls.Edit.SentenceControl;
using LangTrainerFrontendWinForms.Service;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class SentenceControl : UserControl
    {
        public event EventHandler<LoadTokenEventArgs> OnLoadToken;

        public SentenceControl()
        {
            InitializeComponent();
        }

        public void Init(Expression expr)
        {
            _lang.Text = expr.Language.Name;
            _text.Text = expr.Text;
        }

        private async void _buttonLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_text.Text) || string.IsNullOrEmpty(_lang.Text))
                return;

            var serv = new LangService();
            var expr = await serv.GetTokenData(_text.Text, _lang.Text);

            OnLoadToken(this, new LoadTokenEventArgs()
            {
                tokenInfo = new TokenInfo()
                {
                    Expression = _text.Text,
                    Language = _lang.Text
                }
            });
        }

    }
}
