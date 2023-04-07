

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class CustomComboBox : UserControl
    {
        private MyDropDownControl _dropDownControl;
        private Form _dropDownForm;
        private bool _isDroppedDown;
        private readonly List<ComboboxItem> _items = new();

        public CustomComboBox()
        {
            InitializeComponent();
        }

        public ComboboxItem SelectedItem { get; set; }

        private void CreateDropDownControl()
        {
            var myDropDownControl = new MyDropDownControl();
            SetDropDownControl(myDropDownControl);
        }

        public void Add(ComboboxItem item)
        {
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        private void ShowDropDown()
        {
            if (_isDroppedDown)
            {
                return;
            }

            _dropDownForm = new NoFocusForm
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                ShowInTaskbar = false
            };

            CreateDropDownControl();
            _dropDownForm.Controls.Add(_dropDownControl);
            
            Point locationOnScreen = this.PointToScreen(new Point(0, this.textBox1.Bottom));
            _dropDownForm.Location = locationOnScreen;
            _dropDownForm.Width = this.Width;

            _dropDownControl.SelectedIndexChanged += _dropDownControl_SelectedIndexChanged;

            _dropDownControl.Dock = DockStyle.Fill;
            //_dropDownForm.Height = _dropDownControl.Height;
            _dropDownForm.Show(this);

            _dropDownControl.SetItems(_items);
            int maxDropDownHeight = 200; // Задайте максимальную высоту выпадающего списка
            _dropDownForm.Height = Math.Min(_dropDownControl.Height, maxDropDownHeight);

            _isDroppedDown = true;

            _dropDownForm.FormClosed += DropDownForm_FormClosed;
            _dropDownForm.Deactivate += _dropDownForm_Deactivate;
        }

        private void _dropDownControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var item = (ComboboxItem)_dropDownControl.SelectedItem;
            textBox1.Text = item.Text;
            HideDropDown();
        }

        private void _dropDownForm_Deactivate(object? sender, EventArgs e)
        {
            HideDropDown();
        }

        private void HideDropDown()
        {
            if (!_isDroppedDown)
            {
                return;
            }

            _dropDownForm.FormClosed -= DropDownForm_FormClosed;
            _dropDownForm.Close();
            _isDroppedDown = false;
        }

        private void DropDownForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HideDropDown();
        }

        public void SetDropDownControl(MyDropDownControl control)
        {
            _dropDownControl = control;
        }

        private void ToggleDropDownButton_Click(object sender, EventArgs e)
        {
            if (_isDroppedDown)
            {
                HideDropDown();
            }
            else
            {
                ShowDropDown();
            }
        }

    }
}
