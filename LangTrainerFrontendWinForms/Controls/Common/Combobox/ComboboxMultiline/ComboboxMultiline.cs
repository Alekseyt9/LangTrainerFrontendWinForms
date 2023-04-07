

namespace LangTrainerFrontendWinForms.Controls
{
    internal class ComboboxMultiline : ComboBox
    {
        public ComboboxMultiline()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            //IntegralHeight = true;
            DrawItem += ComboBox1_DrawItem;
            MeasureItem += ComboBox1_MeasureItem;
            //this.DropDown += ComboboxMultiline_DropDown;
            ItemHeight = 40;
            //DropDownHeight = 1000;
        }

        private void ComboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }

            ComboBox comboBox = (ComboBox)sender;
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

        private void ComboBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }

            ComboBox comboBox = (ComboBox)sender;
            string itemText = comboBox.GetItemText(comboBox.Items[e.Index]);

            // Вычисление размера текста с учетом переносов строки
            SizeF textSize = e.Graphics.MeasureString(itemText, comboBox.Font, comboBox.Width);
            e.ItemHeight = (int)textSize.Height;
            e.ItemWidth = (int)textSize.Width;
        }

    }
}
