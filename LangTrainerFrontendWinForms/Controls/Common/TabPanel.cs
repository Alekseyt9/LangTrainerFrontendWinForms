

namespace LangTrainerFrontendWinForms.Controls.Common
{
    public partial class TabPanel : UserControl
    {
        private Dictionary<string, Control> _map = new();

        public TabPanel()
        {
            InitializeComponent();
        }

        public void Add(string key, Control ctr)
        {
            _map[key] = ctr;
        }

        public void Navigate(string key)
        {
            Controls.Clear();
            var ctr = _map[key];
            //ctr.Padding = new Padding(0);
            //ctr.Margin = new Padding(0);
            ctr.Dock = DockStyle.Fill;
            Controls.Add(ctr);
        }

    }
}
