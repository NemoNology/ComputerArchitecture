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
            ReloadCache();

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


                if (!oldLine.Equals(""))
                {
                    if (index % 10 == 0)
                    {
                        index = 10;
                    }
                    else
                    {
                        index = index % 10;
                    }

                    string temp = _cache.Rows[index - 1].Cells[2].Value.ToString();
                    MM.SetLine(oldLine, (Convert.ToInt32(temp) - 1) * 10 + index);
                }
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
            _loadPlace.Text = "ОП";
            string[] key = _addr.Text.Split(' ');

            string time = "", el = "", line = "";

            MM.SearchByAddr(Convert.ToInt32(key[0]), Convert.ToInt32(key[1]) + 1, Convert.ToInt32(key[2]) + 1,
                out time, out el, out line);

            _time.Text = time;
            _loadEl.Text = el;
            _loadLine.Text = line;
        }

        private void _cache_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_cache.CurrentCell.ColumnIndex == 1) //_cache.SelectedCells.Count == 1 && _cache.CurrentCell.ColumnIndex == 1)
            {
                newLine.Text = _cache.CurrentCell.Value.ToString().Replace(' ', ',');
            }
        }

        private void changeLine_Click(object sender, EventArgs e)
        {
            if (Cache.GetLine(_cache.CurrentCell.RowIndex + 1) == "   ")
            {
                return;
            }


            string[] numbers = newLine.Text.Split(',');
            string readyLine = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                readyLine += numbers[i].PadLeft(MM.ns, '0').Replace(' ', '0') + " ";
            }

            Cache.SetLine(readyLine, _cache.CurrentCell.RowIndex + 1);

            ReloadCache();

        }

        public void ReloadCache()
        {
            string t1, t2;
            string[] pages = new string[MM.la];

            for (int i = 0; i < MM.la; i++)
            {
                pages[i] = _cache.Rows[i].Cells[2].Value.ToString();
            }

            _cache.Rows.Clear();


            for (int i = 1; i <= MM.la; i++)
            {
                int index = MM.SearchByKey(Cache.GetLine(i), out t1, out t2);

                if (index % 10 == 0)
                {
                    index--;
                }

                if (index != -1)
                {
                    _cache.Rows.Add(i, Cache.GetLine(i), index / 10 + 1);
                }
                else
                {
                    _cache.Rows.Add(i, Cache.GetLine(i), pages[i - 1]);
                }
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
