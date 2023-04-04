

namespace LangTrainerFrontendWinForms.Controls
{
    internal class TabPanelItem
    {
        public Control Control { get; set; }

        public Action<Control> InitAction { get; set; }

        public bool IsInit { get; set; }
    }
}
