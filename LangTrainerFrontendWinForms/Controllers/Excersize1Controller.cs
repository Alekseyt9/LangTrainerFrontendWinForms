

using LangTrainerClientModel.Model.Training;

namespace LangTrainerFrontendWinForms.Controllers
{
    internal class Excersize1Controller
    {
        private Button[] _buttons;
        private RichTextBox _label;

        public Excersize1Controller(Button[] buttons, RichTextBox label)
        {
            _buttons = buttons;
            _label = label;
        }

        public void Init(Excercize1Model model)
        {
            for (var i = 0; i < 4; i++)
            {
                _buttons[i].Text = model.Variants[i];
            }

            _label.Lines = new string[] { model.Question };
        }

    }
}
