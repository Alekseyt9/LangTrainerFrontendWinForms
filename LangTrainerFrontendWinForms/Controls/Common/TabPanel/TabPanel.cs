

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class TabPanel : UserControl
    {

        private readonly Dictionary<string, TabPanelItem> _map = new();

        public TabPanel()
        {
            InitializeComponent();
        }

        public void Add(string key, Control ctr, Action<Control> initAction = null)
        {
            _map[key] = new TabPanelItem()
            {
                Control = ctr,
                InitAction = initAction,
                IsInit = false
            };
        }

        public void Navigate(string key)
        {
            Controls.Clear();
            var item = _map[key];
            var ctr = item.Control;
            ctr.Dock = DockStyle.Fill;
            Controls.Add(ctr);

            if (!item.IsInit)
            {
                item.InitAction?.Invoke(ctr);
                item.IsInit = true;
            }
        }

    }
}
