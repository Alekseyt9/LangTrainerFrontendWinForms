

namespace LangTrainerFrontendWinForms.Services
{
    internal class NotifyService
    {
        private static NotifyService instance;

        private NotifyIcon _ctr;

        private NotifyService()
        { }

        public void Init(NotifyIcon ctr)
        {
            _ctr = ctr;
        }

        public static NotifyService GetInstance()
        {
            if (instance == null)
            {
                instance = new NotifyService();
            }
            return instance;
        }

        public void ShowMessage(string msg)
        {
            _ctr.Text = msg;
            _ctr.ShowBalloonTip(3, "", msg, ToolTipIcon.Info);
        }

    }
}
