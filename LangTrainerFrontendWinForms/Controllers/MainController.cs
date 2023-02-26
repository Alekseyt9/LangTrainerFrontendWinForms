
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Model;
using System.Linq;

namespace LangTrainerFrontendWinForms.Controllers
{
    internal class MainController
    {
        private TabControl _tab;
        private MainModel _model;
        private int _State;

        public MainController(TabControl tab, MainModel model)
        {
            _tab = tab;
            _model = model;
            _State = 2;
        }

        public void Next()
        {
            _State++;
            switch (_State)
            {
                case 1:
                    ActivatePage(_State);
                    var container = _tab.TabPages[_tab.SelectedIndex];
                    var ctr = new Excersize1Controller(
                        container.Find<Button>().ToArray(),
                        container.Find<RichTextBox>("Question").First()
                    );
                    ctr.Init(_model.Model1);
                    break;
            }
        }

        private void ActivatePage(int num)
        {

        }

    }

}
