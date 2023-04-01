using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LangTrainerFrontendWinForms.Controls.Out.Accordion
{

    public class MultiKey
    {

        public StringComparer Comparer { get; private set; }
        private IList<object> keys2 = null;

        public MultiKey(IEnumerable e)
        { //ICollection col) {
            if (e is Array)
            {
                Array arr = (Array)e;
                keys2 = new object[arr.Length];
                for (int i = keys2.Count - 1; i >= 0; i--)
                    keys2[i] = arr.GetValue(i);
            }
            else if (e is IList)
            {
                IList list = (IList)e;
                keys2 = new object[list.Count];
                for (int i = list.Count - 1; i >= 0; i--)
                    keys2[i] = list[i];
            }
            else
            {
                //keys.AddRange(col);
                keys2 = new List<object>();
                var e2 = e.GetEnumerator();
                while (e2.MoveNext())
                    keys2.Add(e2.Current);
            }
        }

        public MultiKey(object key1, object key2, params object[] keys)
        {
            keys2 = new object[2 + keys.Length];
            keys2[0] = key1;
            keys2[1] = key2;
            for (int i = keys.Length - 1; i >= 0; i--)
                keys2[i + 2] = keys[i];
        }

        public MultiKey(StringComparer comparer, params object[] keys)
        {
            Comparer = comparer;
            keys2 = new object[keys.Length];
            for (int i = keys.Length - 1; i >= 0; i--)
                keys2[i] = keys[i];
        }

        public object[] Keys
        {
            get
            {
                return keys2.ToArray();
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is MultiKey))
                return false;

            MultiKey mk = (MultiKey)obj;
            if (mk.keys2.Count != keys2.Count)
                return false;

            var c = Comparer;
            if (c != null)
            {
                for (int i = 0; i < mk.keys2.Count; i++)
                {
                    object o1 = mk.keys2[i];
                    object o2 = keys2[i];
                    if (o1 == null)
                    {
                        if (o2 == null)
                            continue;
                        return false;
                    }

                    if (o1 is string && o2 is string)
                    {
                        if (c.Compare((string)o1, (string)o2) != 0)
                            return false;
                    }
                    else if (!o1.Equals(o2))
                        return false;
                }
            }
            else
            {
                for (int i = 0; i < mk.keys2.Count; i++)
                {
                    object o1 = mk.keys2[i];
                    object o2 = keys2[i];
                    if (o1 == null)
                    {
                        if (o2 == null)
                            continue;
                        return false;
                    }
                    if (!o1.Equals(o2))
                        return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            { // Overflow is fine, just wrap
                int hash = 17;
                var c = Comparer;
                if (c != null)
                {
                    foreach (object o in keys2)
                    {
                        if (o == null)
                            continue;

                        int hc;
                        if (o is string)
                            hc = c.GetHashCode((string)o);
                        else
                            hc = o.GetHashCode();

                        hash = hash * 29 + hc;
                    }
                }
                else
                {
                    foreach (object o in keys2)
                    {
                        if (o == null)
                            continue;
                        hash = hash * 29 + o.GetHashCode();
                    }
                }

                return hash;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object o in keys2)
            {
                if (sb.Length > 0)
                    sb.Append(", ");

                if (o is DateTime)
                    sb.Append(((DateTime)o).ToString("yyyy-MM-dd"));
                else
                    sb.Append(o.ToString());
            }
            return sb.ToString();
        }
    }
}