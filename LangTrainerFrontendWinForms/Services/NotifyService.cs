
using LangTrainerCommon.Helpers;

namespace LangTrainerFrontendWinForms.Services
{
    internal class NotifyService
    {
        private static NotifyService instance;

        private ToolTip _ctr;
        private Form _form;

        private NotifyService()
        { }

        public void Init(Form form, ToolTip ctr)
        {
            _ctr = ctr;
            _form = form;
        }

        public static NotifyService GetInstance()
        {
            if (instance == null)
            {
                instance = new NotifyService();
            }
            return instance;
        }

        private Size GetTextSize(string msg)
        {
            var size = TextRenderer.MeasureText(msg, SystemFonts.MessageBoxFont);
            return new Size((int)(size.Width * 0.5), (int)(size.Height * 0.5));
        }

        public void ShowMessage(string msg, float vertScale = 0.7f)
        {
            _form.Invoke(() =>
            {
                var wText = StringHelper.WrapText(msg, 50);
                var point = new Point((int)(_form.Width * 0.5), (int)(_form.Height * vertScale)) - GetTextSize(wText);
                _ctr.Show(wText, _form, point, 3000);
            });
        }

    }
}
