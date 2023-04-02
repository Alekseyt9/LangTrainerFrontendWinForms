
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace LangTrainerFrontendWinForms.Helpers
{
    public static class FormHelper
    {
        public static IEnumerable<T> Find<T>(this Control control, string pattern = null)
        {
            var res = new List<T>();
            var regex = pattern != null ? new Regex(pattern) : null;
            FindRecurs<T>(control, regex, res);
            return res;
        }

        private static void FindRecurs<T>(Component control, Regex regex, List<T> list)
        {
            if (control.Container != null)
            {
                foreach (Component child in control.Container.Components)
                {
                    if (child is T child1)
                    {
                        var ctr = child as Control;
                        if (regex != null && ctr != null && regex.IsMatch(ctr.Name) || regex == null)
                        {
                            list.Add(child1);
                        }
                    }

                    FindRecurs<T>(child, regex, list);
                }
            }
            else
            {
                foreach (Component child in ((Control)control).Controls)
                {
                    if (child is T child1)
                    {
                        var ctr = child as Control;
                        if (regex != null && ctr != null && regex.IsMatch(ctr.Name) || regex == null)
                        {
                            list.Add(child1);
                        }
                    }

                    FindRecurs<T>(child, regex, list);
                }
            }
        }

        public static void DoRecurs(this Control control, Action<Control> act)
        {
            if (act != null)
            {
                act(control);
            }

            foreach (Control child in control.Controls)
            {
                DoRecurs(child, act);
            }
        }

        public static void SetPage(this TabControl tabControl, string name)
        {
            tabControl.SelectTab(tabControl.TabPages.IndexOfKey(name));
        }

        public static void HideHeader(this TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        public static Control FindControlAtPoint(Control container, Point pos)
        {
            Control child;
            foreach (Control c in container.Controls)
            {
                if (c.Visible && c.Bounds.Contains(pos))
                {
                    child = FindControlAtPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
                    if (child == null) return c;
                    else return child;
                }
            }
            return null;
        }

        public static Control FindControlAtCursor(Form form)
        {
            var pos = Cursor.Position;
            if (form.Bounds.Contains(pos))
                return FindControlAtPoint(form, form.PointToClient(pos));
            return null;
        }

    }
}
