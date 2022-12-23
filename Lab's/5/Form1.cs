using System;
using System.Windows.Forms;

namespace ЭВМ_Лаб_4__WF_
{
    public partial class Form1 : Form
    {
        

        string[] lines = new string[MM.pa * MM.la];

        public Form1()
        {
            InitializeComponent();
            MM.Create();
            Cache.Load();

            lines = MM.GetLines();

            for (int i = 0; i < lines.Length; i++)
            {
                _mm.Rows.Add(i + 1, lines[i], i / 10 + 1);
            }

            for (int i = 0; i < MM.la; i++)
            {
                _cache.Rows.Add(i + 1, Cache.GetLine(i), " ");
            }

        }

        private void searchKey_Click(object sender, EventArgs e)
        {
            string key = _key.Text.Replace(" ", string.Empty).Replace(',', ' ').Trim(' ');
            _loadEl.Text = _key.Text;

            _loadPlace.Text = "КЭШ";

            if (!Cache.SearchByKey(key, out string time, out string line))
            {
                int index = MM.SearchByKey(key, out time, out line);

                _loadPlace.Text = "ОП";
                _time.Text = time;
                _loadLine.Text = line;

                if (index == -1)
                {
                    _loadPlace.Text = "...";
                    _loadEl.Text = "Элемент не найден";
                    return;
                }

                string oldLine = Cache.SetLine(lines[index], index % 10);

                int page = index / 10;

                _cache.Rows[index - page * 10].Cells[2].Value = page;

                if (!oldLine.Equals(""))
                {
                    MM.SetLine(oldLine, index);
                }
            }

            _time.Text = time;
            _loadLine.Text = line;

            ReloadMM();
            ReloadCache();
        }

        
        public void FromAddrToCache(bool IsSearch, EventArgs e)
        {
            _loadPlace.Text = "КЭШ";
            string[] addr = _addr.Text.Split(' ');

            int p = Convert.ToInt32(addr[0]);
            int l = Convert.ToInt32(addr[1]);
            int n = Convert.ToInt32(addr[2]);

            if (n > MM.na)
            {
                _loadPlace.Text = "...";
                _time.Text = "...";
                _loadEl.Text = "Элемент не найден";
                _loadLine.Text = "...";
                return;
            }

            if (!Cache.SearchByAddr(l, n, 
                out string time, out string el, out string line) 
                || !IsSamePage(p, l))
            {
                _loadPlace.Text = "ОП";

                MM.SearchByAddr(p, l, n,
                    out time, out el, out line);

                string oldLine;

                if (IsSearch)
                {
                    oldLine = Cache.SetLine(line, l);
                }
                else
                {
                    oldLine = Cache.SetLine(GNL(p, l, n), l);
                }

                if (!oldLine.Equals(string.Empty))
                {
                    MM.SetLine(oldLine, (Convert.ToInt32(_cache.Rows[l].Cells[2].Value) - 1) * 10 + l);

                    ReloadMM();
                }

                _cache.Rows[l].Cells[2].Value = p + 1;
            }
            else
            {
                Cache.SetLine(GNL(p, l, n), l);
            }

            
            ReloadCache();

            _time.Text = time;
            _loadEl.Text = el;
            _loadLine.Text = line;
        }

        private void searchAddr_Click(object sender, EventArgs e)
        {
            FromAddrToCache(true, e);
        }

        private void changeLine_Click(object sender, EventArgs e)
        {
            FromAddrToCache(false, e);

        }

        public void ReloadCache()
        {
            string[] pages = new string[MM.la];

            for (int i = 0; i < MM.la; i++)
            {
                pages[i] = _cache.Rows[i].Cells[2].Value.ToString();
            }

            _cache.Rows.Clear();

            for (int i = 0; i < MM.la; i++)
            {
                _cache.Rows.Add(i + 1, Cache.GetLine(i), pages[i]);
            }
        }

        public void ReloadMM()
        {
            string[] lines = MM.GetLines();

            _mm.Rows.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                _mm.Rows.Add(i + 1, lines[i], i / 10 + 1);
            }
        }

        public bool IsSamePage(int Page, int line)
        {
            try
            {
                int currPage = Convert.ToInt32(_cache.Rows[line].Cells[2].Value) - 1;

                if (currPage == Page)
                {
                    return true;
                }

                return false;

            }
            catch
            {
                return false;
            }
        }

        public string GNL(int page, int line, int number)
        {
            string[] NL = { newLine1.Text, newLine2.Text, newLine3.Text, newLine4.Text };

            string res = string.Empty;

            for (int i = 0; i < NL.Length; i++)
            {
                if (NL[i].Equals(string.Empty))
                {
                    MM.SearchByAddr(page, line, number, out _, out _, out string num);
                    NL[i] = num;
                }

                res += NL[i] + " ";
            }

            return res.Substring(0, res.Length - 1);
        }

        private void _cache_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FromGridToFields(_cache, e);
        }

        private void _mm_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FromGridToFields(_mm, e);
        }

        public void FromGridToFields(DataGridView Grid, DataGridViewCellEventArgs e)
        {
            _key.Text = Grid.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(",", string.Empty).Replace(" ", string.Empty);
            _addr.Text = (Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[2].Value.ToString()) - 1).ToString() +
                (e.RowIndex % 10) + 0;
            string[] line = _key.Text.Split(' ', ',');

            newLine1.Text = line[0];
            newLine2.Text = line[1];
            newLine3.Text = line[2];
            newLine4.Text = line[3];
        }

        private void rewriteMM_Click(object sender, System.EventArgs e)
        {
            _mm.Rows.Clear();

            Cache.Load();

            _cache.Rows.Clear();

            for (int i = 0; i < MM.la; i++)
            {
                _cache.Rows.Add(i + 1, string.Empty, string.Empty);
            }

            MM.Create();

            lines = MM.GetLines();

            for (int i = 0; i < lines.Length; i++)
            {
                _mm.Rows.Add(i + 1, lines[i], i / 10 + 1);
            }
        }
		
		// todo: Before app closing MM.DeleteFile()

    }
}
