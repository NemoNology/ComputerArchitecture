using System;
using System.IO;
using System.Diagnostics;

namespace ЭВМ_Лаб_4__WF_
{
    class Cache
    {

        public static string[][] _cache = new string[MM.la][];


        public static void Load()
        {
            for (int i = 0; i < MM.la; i++)
            {
                _cache[i] = new string[MM.na];
            }
        }

        public static string GetLine(int index)
        {
            string res = "";

            if (index == 0)
            {
                index = 9;
            }
            else
            {
                index--;
            }

            for (int i = 0; i < MM.na; i++)
            {
                res += _cache[index][i] + " ";
            }

            return res.Substring(0, res.Length - 1);
        }

        public static string[] GetLines()
        {
            string[] res = new string[MM.la];

            for (int i = 1; i <= MM.la; i++)
            {
                res[i - 1] = GetLine(i);
            }

            return res;
        }

        public static int SearchByKey(string key,
            out string time, out string _line)
        {
            Stopwatch st = new Stopwatch();

            st.Start();

            for (int i = 0; i < MM.la; i++)
            {
                for (int j = 0; j < MM.na; j++)
                {

                    if (key == _cache[i][j])
                    {
                        st.Stop();

                        time = st.ElapsedTicks.ToString();
                        _line = GetLine(i);

                        return 1;
                    }
                }

            }

            st.Stop();

            time = st.ElapsedTicks.ToString();
            _line = "...";

            return -1;
        }

        public static string SetLine(string data, int index)
        {
            if (index > _cache.Length)
            {
                return "";
            }
            else if (index == 0)
            {
                index = 10;
            }

            if (_cache[index - 1][0] != null)
            {
                string res = "";

                for (int i = 0; i < MM.na; i++)
                {
                    res += _cache[index - 1][i] + " ";
                }

                _cache[index - 1] = data.Split(' ', ',');
                return res.Substring(0, res.Length - 1);
            }

            _cache[index - 1] = data.Split(' ', ',');
            return "";

        }

        public static bool SearchByAddr(int line, int number,
            out string time, out string el, out string _line)
        {
            Stopwatch st = new Stopwatch();

            st.Start();

            el = _cache[line][number];

            st.Stop();

            time = st.ElapsedTicks.ToString();

            if (el == null)
            {
                el = "...";
                _line = el;
                return false;
            }

            _line = GetLine(line);
            return true;

        }

    }
}
