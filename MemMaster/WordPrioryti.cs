using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemMaster
{
    class WordPrioryti
    {
        public double prioryti;
        public string word;
        public List<char> els = new List<char>();

        public bool ContainAllSymbols(string str)
        {
            for (int i = 0; i < els.Count; i++)
                if (!str.Contains(els[i]))
                    return false;
            return true;
        }

        public WordPrioryti(DataGridViewRow row)
        {
            word = ((string)row.Cells[0].Value).ToLower();
            string str = word;
            int i = 0;
            while (true)
            {
                var tmp = str[i].ToString();
                str = str.Replace(tmp, "");
                str = str.Insert(i, tmp);
                i++;
                if (str.Length - 1 < i)
                    break;
            }
            for (i = 0; i < str.Length; i++)
                els.Add(str[i]);
            try
            {
                prioryti = Convert.ToDouble((string)row.Cells[1].Value);
            }
            catch
            {
                prioryti = 0;
            }
        }
    }
}
