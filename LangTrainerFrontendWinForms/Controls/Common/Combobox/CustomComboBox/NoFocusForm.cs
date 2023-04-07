

namespace LangTrainerFrontendWinForms.Controls
{
    public class NoFocusForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x08000000; // WS_EX_NOACTIVATE
                return createParams;
            }
        }

        /*
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
        */
    }
}
