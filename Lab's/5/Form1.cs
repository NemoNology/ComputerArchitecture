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

        private void rewriteMM_Click(object sender, System.EventArgs e)
        {
            _mm.Rows.Clear();

            Cache.Load();

            _cache.Rows.Clear();

            for (int i = 1; i <= MM.la; i++)
            {
                _cache.Rows.Add(i, Cache.GetLine(i), string.Empty);
            }

            MM.Create();

            lines = MM.GetLines();

            for (int i = 0; i < lines.Length; i++)
            {
                _mm.Rows.Add(i + 1, lines[i], i / 10 + 1);
            }
        }

        private void searchKey_Click(object sender, System.EventArgs e)
        {
            string key = _key.Text.PadLeft(MM.ns, '0').Replace(' ', '0');
            _loadEl.Text = _key.Text;
            string time = "", line = "";
            

            if (Cache.SearchByKey(key, out time, out line) != -1)
            {
                _loadPlace.Text = "КЭШ";
                _time.Text = time;
                _loadLine.Text = line;
                return;
            }
            else
            {
                int index = MM.SearchByKey(key, out time, out line);
                int page = (index - 1) / 10;

                _loadPlace.Text = "ОП";
                _time.Text = time;
                _loadLine.Text = line;

                if (index == -1)
                {
                    _loadPlace.Text = "...";
                    _loadEl.Text = "Элемент не найден";
                    _loadLine.Text = "...";
                    return;
                }

                string oldLine = Cache.SetLine(lines[index - 1], index % 10);

                if (index % 10 == 0)
                {
                    index = 10;
                }
                else
                {
                    index = index % 10;
                }

                if (!oldLine.Equals(string.Empty))
                {
                    MM.SetLine(oldLine, page * 10 + index);
                }

                _cache.Rows[index - 1].Cells[2].Value = page + 1;

            }

            ReloadMM();

            int ind = MM.SearchByKey(key, out time, out line);
            if (ind != -1)
            {
                lines = MM.GetLines();
                Cache.SetLine(lines[ind - 1], ind % 10);
            }

            ReloadCache();
        }

        private void searchAddr_Click(object sender, EventArgs e)
        {

            string[] key = _addr.Text.Split(' ');
            string time = "", el = "", line = "";
            _loadPlace.Text = "КЭШ";

            if (Convert.ToInt32(key[2]) > 3)
            {
                _time.Text = "...";
                _loadEl.Text = "Елемент не найден";
                _loadLine.Text = "...";
                _loadPlace.Text = "...";
                return;
            }

            string currPage = _cache.Rows[Convert.ToInt32(key[1])].Cells[2].Value.ToString();
            

            if (!Cache.SearchByAddr(Convert.ToInt32(key[1]), Convert.ToInt32(key[2]),
                out time, out el, out line) || (!currPage.Equals(key[0]) && !currPage.Equals(string.Empty)))
            {
                _loadPlace.Text = "ОП";

                MM.SearchByAddr(Convert.ToInt32(key[0]), Convert.ToInt32(key[1]), Convert.ToInt32(key[2]) + 1,
                    out time, out el, out line);

                string oldLine = Cache.SetLine(line, Convert.ToInt32(key[1]) + 1);
                _cache.Rows[Convert.ToInt32(key[1])].Cells[2].Value = Convert.ToInt32(key[0]);

                if (!oldLine.Equals(string.Empty))
                {
                    MM.SetLine(oldLine, Convert.ToInt32(key[0]) * 10 + Convert.ToInt32(key[1]));
                }

                ReloadMM();
                ReloadCache();

            }
            
            _time.Text = time;
            _loadEl.Text = el;
            _loadLine.Text = line;

        }

        private void _cache_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string page = _cache.Rows[_cache.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string line = (_cache.CurrentCell.RowIndex).ToString();

            if (_cache.CurrentCell.ColumnIndex == 1)
            {
                newLine.Text = _cache.CurrentCell.Value.ToString().Replace(' ', ',');
                _addr.Text = page + line + "0";
            }
        }

        private void changeLine_Click(object sender, EventArgs e)
        {
            string[] data = _addr.Text.Split(' ');

            int page = Convert.ToInt32(data[0]);
            int line = Convert.ToInt32(data[1]);
            int number = Convert.ToInt32(data[2]);

            if (number > 3)
            {
                _time.Text = "...";
                _loadEl.Text = "Елемент не найден";
                _loadLine.Text = "...";
                _loadPlace.Text = "...";
                return;
            }

            string currPage = _cache.Rows[line].Cells[2].Value.ToString();
            _loadPlace.Text = "КЭШ";
            string time = "", el = "", _line = "";

            if (Cache.SearchByAddr(line, number,
               out time, out el, out _line) && (currPage.Equals(page.ToString())))
            {
                try
                {
                    Cache.SetLine(newLine.Text, line + 1);
                }
                catch
                {
                    _time.Text = time;
                    _loadEl.Text = "Неверно задана новая строка!";
                    _loadLine.Text = "...";
                }

                ReloadCache();
            }
            else
            {
                _loadPlace.Text = "ОП";

                MM.SearchByAddr(page, line, number, out time, out el, out _line);

                _cache.Rows[line].Cells[2].Value = page + 1;
                
                string oldLine = Cache.SetLine(newLine.Text, line + 1);

                if (!oldLine.Equals(string.Empty))
                {
                    MM.SetLine(oldLine, Convert.ToInt32(currPage) * 10 + line + 1);
                }

                ReloadMM();
                ReloadCache();
            }
                
            _time.Text = time;
            _loadEl.Text = el;
            _loadLine.Text = _line;

        }

        public void ReloadCache()
        {
            string[] pages = new string[MM.la];

            for (int i = 0; i < MM.la; i++)
            {
                pages[i] = _cache.Rows[i].Cells[2].Value.ToString();
            }

            _cache.Rows.Clear();

            for (int i = 1; i <= MM.la; i++)
            {
                _cache.Rows.Add(i, Cache.GetLine(i), pages[i - 1]);
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

    }
}
