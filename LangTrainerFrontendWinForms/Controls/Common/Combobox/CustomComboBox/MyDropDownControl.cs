

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class MyDropDownControl : ListBox
    {

        //private ListBox _listBox;

        public MyDropDownControl()
        {
            InitializeComponent();

            ///_listBox = new ListBox();
            //Dock = DockStyle.Fill;
            //Controls.Add(_listBox);

            DrawMode = DrawMode.OwnerDrawVariable;
            DrawItem += _listBox_DrawItem;
            MeasureItem += _listBox_MeasureItem;

            // Заполняем ListBox данными
            Items.Add("Текст 3\nВторая строка");
            Items.Add("Текст 3\nВторая строка\nТретья строка");
            Items.Add("Текст 3\nВторая строка"); 
            Items.Add("Текст 3\nВторая строка\nТретья строка");
        }

        public int CalculateDropDownControlHeight()
        {
            var listBox = this;
            int totalItemHeight = 0;

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                totalItemHeight += listBox.GetItemHeight(i);
            }

            // Добавьте высоту границ и прокрутки, если нужно
            //int borderAndScrollHeight = listBox.Margin.Vertical + SystemInformation.HorizontalScrollBarHeight;
            int borderAndScrollHeight = 0;

            return totalItemHeight + borderAndScrollHeight;
        }

        public void SetItems(IEnumerable<ComboboxItem> items)
        {
            Items.Clear();
            foreach (ComboboxItem item in items)
            {
                Items.Add(item);
            }
        }

        private void _listBox_MeasureItem(object? sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }

            ListBox comboBox = (ListBox)sender;
            string itemText = comboBox.GetItemText(comboBox.Items[e.Index]);

            // Вычисление размера текста с учетом переносов строки
            SizeF textSize = e.Graphics.MeasureString(itemText, comboBox.Font, comboBox.Width);
            e.ItemHeight = (int)textSize.Height;
            e.ItemWidth = (int)textSize.Width;
        }

        private void _listBox_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }

            ListBox comboBox = (ListBox)sender;
            string itemText = comboBox.GetItemText(comboBox.Items[e.Index]);

            // Отрисовка фона
            e.DrawBackground();

            // Отрисовка текста с учетом переносов строки
            using (StringFormat sf = new StringFormat { LineAlignment = StringAlignment.Center })
            {
                e.Graphics.DrawString(itemText, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sf);
            }

            e.DrawFocusRectangle();
        }

        // Дополнительные свойства и методы, если нужно

    }
}
