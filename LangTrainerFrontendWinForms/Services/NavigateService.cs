

using LangTrainerFrontendWinForms.Helpers;

namespace LangTrainerFrontendWinForms.Services
{
    internal class NavigateService
    {
        private static NavigateService _instance;
        private TabControl _tabControl;

        private NavigateService() { }

        public static NavigateService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NavigateService();
            }
            return _instance;
        }

        public void Init(TabControl tabControl)
        {
            _tabControl = tabControl;
        }

        public void Navigate(string key)
        {
            _tabControl.SetPage(key);
        }

    }
}
