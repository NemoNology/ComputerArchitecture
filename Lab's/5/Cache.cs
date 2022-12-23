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

            for (int i = 0; i < MM.na; i++)
            {
                res += _cache[index][i] + " ";
            }

            return res.Substring(0, res.Length - 1);
        }

        public static bool SearchByKey(string key,
            out string time, out string _line)
        {
            
            Stopwatch st = new Stopwatch();

            st.Start();

            for (int i = 0; i < MM.la; i++)
            {
                for (int j = 0; j < MM.na; j++)
                {
                    try
                    {
                        if (key.IndexOf(_cache[i][j]) != -1)
                        {
                            st.Stop();

                            time = st.ElapsedTicks.ToString();
                            _line = GetLine(i);

                            return true;
                        }
                    }
                    catch
                    {

                    }
                }

            }

            st.Stop();

            time = st.ElapsedTicks.ToString();
            _line = "...";

            return false;
        }

        public static bool SearchByAddr(int line, int number,
            out string time, out string el, out string _line)
        {
            Stopwatch st = new Stopwatch();

            st.Start();

            try
            {
                el = _cache[line][number];
                st.Stop();
                time = st.ElapsedTicks.ToString();
                _line = GetLine(line);
                return true;
            }
            catch
            {
                st.Stop();
                el = "Элемент не найден";
                time = st.ElapsedTicks.ToString();
                _line = "...";
                return false;
            }
        }

        public static string SetLine(string data, int index)
        {
            if (index > _cache.Length || index < 0)
            {
                return string.Empty;
            }

            if (_cache[index][0] != null)
            {
                string res = string.Empty;

                for (int i = 0; i < MM.na; i++)
                {
                    res += _cache[index][i] + " ";
                }

                _cache[index] = data.Split(' ', '.', ',');
                return res.Substring(0, res.Length - 1);
            }

            _cache[index] = data.Split(' ');
            return string.Empty;

        }


    }
}
