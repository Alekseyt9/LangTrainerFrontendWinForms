
using LangTrainerFrontendWinForms.Controls.Common;

namespace LangTrainerFrontendWinForms.Services
{
    internal class LangFilterService
    {
        public event EventHandler LangChanged;

        public FilterData Data
        {
            get { return null; }
        }

        private static LangFilterService _instance;

        private LangFilterService() { }

        public void Init(ToolStripMenuItem optItem)
        {

        }

        public static LangFilterService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LangFilterService();
            }
            return _instance;
        }

    }
}
