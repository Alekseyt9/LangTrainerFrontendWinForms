
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

        private static void FindRecurs<T>(Control control, Regex regex, List<T> list)
        {
            foreach (Control child in control.Controls)
            {
                if (child is T child1)
                {
                    if (regex != null && regex.IsMatch(child.Name) || regex == null)
                    {
                        list.Add(child1);
                    }
                }
                FindRecurs<T>(child, regex, list);
            }
        }

    }
}
