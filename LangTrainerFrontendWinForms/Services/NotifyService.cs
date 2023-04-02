
using LangTrainerCommon.Helpers;

namespace LangTrainerFrontendWinForms.Services
{
    internal class NotifyService
    {
        private static NotifyService instance;
        private Form _form;
        private ToolTip _toolTip;

        private NotifyService()
        { }

        public void Init(Form form, ToolTip toolTip)
        {
            _form = form;
            _toolTip = toolTip;
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

        public void ShowMessage(string msg, Form form = null, ToolTip toolTip = null, float vertScale = 0.7f)
        {
            var f = form != null ? form : _form;
            var tt = toolTip != null ? toolTip : _toolTip;

            f.Invoke(() =>
            {
                var wText = StringHelper.WrapText(msg, 50);
                var point = new Point((int)(f.Width * 0.5), (int)(f.Height * vertScale)) - GetTextSize(wText);
                tt.Show(wText, f, point, 3000);
            });
        }

    }
}
