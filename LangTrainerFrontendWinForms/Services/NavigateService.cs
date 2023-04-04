

using LangTrainerFrontendWinForms.Controls;

namespace LangTrainerFrontendWinForms.Services
{
    internal class NavigateService
    {
        private static NavigateService _instance;
        private TabPanel _tabPanel;

        private NavigateService() { }

        public static NavigateService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NavigateService();
            }
            return _instance;
        }

        public void Init(TabPanel tabPanel)
        {
            _tabPanel = tabPanel;
        }

        public void Navigate(string key)
        {
            _tabPanel.Navigate(key);
        }

    }
}
