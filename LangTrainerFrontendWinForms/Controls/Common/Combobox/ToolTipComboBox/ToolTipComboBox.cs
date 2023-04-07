
using System.Runtime.InteropServices;

namespace LangTrainerFrontendWinForms.Controls
{
    public class ToolTipComboBox : ComboBox
    {
        #region Fields

        private ToolTip toolTip;
        private bool _tooltipVisible;
        private bool _dropDownOpen;

        #endregion

        #region Types

        [StructLayout(LayoutKind.Sequential)]
        public struct COMBOBOXINFO
        {
            public int cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public ComboBoxButtonState buttonState;
            public IntPtr hwndCombo;
            public IntPtr hwndEdit;
            public IntPtr hwndList;
        }

        public enum ComboBoxButtonState
        {
            StateSystemNone = 0,
            StateSystemInvisible = 0x00008000,
            StateSystemPressed = 0x00000008
        }

        [DllImport("user32.dll")]
        public static extern bool GetComboBoxInfo(IntPtr hWnd, ref COMBOBOXINFO pcbi);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        #endregion

        #region Properties

        private IntPtr HwndCombo
        {
            get
            {
                var pcbi = new COMBOBOXINFO();
                pcbi.cbSize = Marshal.SizeOf(pcbi);
                GetComboBoxInfo(Handle, ref pcbi);
                return pcbi.hwndCombo;
            }
        }

        private IntPtr HwndDropDown
        {
            get
            {
                var pcbi = new COMBOBOXINFO();
                pcbi.cbSize = Marshal.SizeOf(pcbi);
                GetComboBoxInfo(Handle, ref pcbi);
                return pcbi.hwndList;
            }
        }

        #endregion

        #region ctor

        public ToolTipComboBox()
        {
            toolTip = new ToolTip
            {
                UseAnimation = false,
                UseFading = false
            };

            /*
        DrawMode = DrawMode.OwnerDrawFixed;
        DrawItem += OnDrawItem;
        DropDownClosed += OnDropDownClosed;
        DropDown += OnDropDown;
        MouseLeave += OnMouseLeave;
            */

            // Настраиваем ComboBox и добавляем обработчик события
            DrawMode = DrawMode.OwnerDrawVariable;
            IntegralHeight = false;
            DrawItem += ComboBox1_DrawItem;
            MeasureItem += ComboBox1_MeasureItem;
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

        #endregion

        #region Methods

        private void OnDropDown(object sender, EventArgs e)
        {
            _dropDownOpen = true;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            ResetToolTip();
        }

        private void ShowToolTip(string text, int x, int y)
        {
            toolTip.Show(text, this, x, y);
            _tooltipVisible = true;
        }

        /*
        void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }

            var cbo = sender as ComboBox;
            var comboBox = (ComboBox)sender;
            var itemText = comboBox.GetItemText(comboBox.Items[e.Index]);
            var text = cbo.GetItemText(cbo.Items[e.Index]);

            // Отрисовка фона и текста
            e.DrawBackground();
            e.Graphics.DrawString(itemText, e.Font, new SolidBrush(e.ForeColor), e.Bounds);

            // Если текст не помещается в ComboBox, показываем его через ToolTip
            if (e.Bounds.Width < TextRenderer.MeasureText(itemText, comboBox.Font).Width)
            {
                toolTip.SetToolTip(comboBox, itemText);
            }
            else
            {
                toolTip.SetToolTip(comboBox, string.Empty);
            }

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                //TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds.Location, SystemColors.Window);

                if (_dropDownOpen)
                {
                    var szText = TextRenderer.MeasureText(text, cbo.Font);
                    if (szText.Width > cbo.Width - SystemInformation.VerticalScrollBarWidth && !_tooltipVisible)
                    {
                        RECT rcDropDown;
                        GetWindowRect(HwndDropDown, out rcDropDown);

                        RECT rcCombo;
                        GetWindowRect(HwndCombo, out rcCombo);

                        if (rcCombo.Top > rcDropDown.Top)
                        {
                            ShowToolTip(text, e.Bounds.X, e.Bounds.Y - rcDropDown.Height - cbo.ItemHeight - 5);
                        }
                        else
                        {
                            ShowToolTip(text, e.Bounds.X, e.Bounds.Y + cbo.ItemHeight - cbo.ItemHeight);
                        }
                    }
                }
            }

            e.DrawFocusRectangle();
        }
        */

        /*
        private void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            var cbo = sender as ComboBox;
            if (e.Index == -1) return;

            var text = cbo.GetItemText(cbo.Items[e.Index]);
            e.DrawBackground();

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds.Location, SystemColors.Window);

                if (_dropDownOpen)
                {
                    var szText = TextRenderer.MeasureText(text, cbo.Font);
                    if (szText.Width > cbo.Width - SystemInformation.VerticalScrollBarWidth && !_tooltipVisible)
                    {
                        RECT rcDropDown;
                        GetWindowRect(HwndDropDown, out rcDropDown);

                        RECT rcCombo;
                        GetWindowRect(HwndCombo, out rcCombo);

                        if (rcCombo.Top > rcDropDown.Top)
                        {
                            ShowToolTip(text, e.Bounds.X, e.Bounds.Y - rcDropDown.Height - cbo.ItemHeight - 5);
                        }
                        else
                        {
                            ShowToolTip(text, e.Bounds.X, e.Bounds.Y + cbo.ItemHeight - cbo.ItemHeight);
                        }
                    }
                }
            }
            else
            {
                ResetToolTip();
                TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds.Location, cbo.ForeColor);
            }

            e.DrawFocusRectangle();
        }
        */


        /*
            void OnDrawItem(object sender, DrawItemEventArgs e)
            {
                if (e.Index < 0)
                    return;

                var text = GetItemText(Items[e.Index]);
                e.DrawBackground();

                using (var br = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(text, e.Font, br, e.Bounds);
                }

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    toolTip.Show(text, this, e.Bounds.Right, e.Bounds.Bottom);
                }
                else
                {
                    toolTip.Hide(this);
                }

                e.DrawFocusRectangle();
            }
            */

        private void OnDropDownClosed(object sender, EventArgs e)
        {
            _dropDownOpen = false;
            ResetToolTip();
        }

        private void ResetToolTip()
        {
            if (_tooltipVisible)
            {
                toolTip.SetToolTip(this, null);
                _tooltipVisible = false;
            }
        }

        #endregion
    }
}
