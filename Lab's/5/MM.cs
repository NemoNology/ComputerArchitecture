using System.IO;
using System;
using System.Diagnostics;

namespace ЭВМ_Лаб_4__WF_
{
    class MM
    {

        private const string fn = "MM.txt";

        public static int pa = 10, la = 10, na = 4, ns = 4;


        public static void Create()
        {
            using (StreamWriter sw = new StreamWriter(fn, false))
            {
                Random r = new Random((int)DateTime.Now.Ticks);

                string temp = "";

                for (int i = 0; i < pa; i++)
                {
                    for (int j = 0; j < la; j++)
                    {
                        for (int k = 0; k < na; k++)
                        {
                            temp += r.Next(0, 9999).ToString().PadLeft(ns, '0') + " ";
                        }

                        sw.WriteLine(temp.Substring(0, temp.Length - 1));
                        temp = "";

                    }

                }
            }
        }

        public static string[] GetLines()
        {
            using (StreamReader sr = new StreamReader(fn))
            {
                string[] res = new string[pa * la];

                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = sr.ReadLine();
                }

                return res;
            }

        }

        public static void SearchByAddr(int page, int line, int number,
                 out string time, out string el, out string _line)
        {
            using (StreamReader sr = new StreamReader(fn))
            {
                Stopwatch st = new Stopwatch();
                string temp = "";
                int counter = 1;

                if (number > na)
                {
                    time = "...";
                    _line = "...";
                    el = "Элемент не найден";
                    return;
                }

                st.Start();

                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine();

                    if (counter == page * 10 + line)
                    {
                        st.Stop();

                        string[] ta = temp.Split(' ');

                        time = st.ElapsedTicks.ToString();
                        _line = temp;
                        el = ta[number - 1];
                        return;
                    }

                    counter++;
                }

                st.Stop();

                time = st.ElapsedTicks.ToString();
                _line = "...";
                el = "Элемент не найден";

            }

        }


        public static int SearchByKey(string key,
            out string time, out string _line)
        {
            using (StreamReader sr = new StreamReader(fn))
            {
                Stopwatch st = new Stopwatch();
                string temp = "";
                int index = 0;

                st.Start();

                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine();
                    index++;

                    if (temp.IndexOf(key) != -1)
                    {
                        st.Stop();

                        time = st.ElapsedTicks.ToString();
                        _line = temp;
                        return index;
                    }

                }

                st.Stop();

                time = st.ElapsedTicks.ToString();
                _line = "...";
                return -1;
            }
        }

        public static void SetLine(string Line, int index)
        {
            if (index > pa * la)
            {
                return;
            }

            FileInfo fi = new FileInfo(fn);

            string nfn = fn.Substring(0, fn.IndexOf(".")) + "2.txt";

            int counter = 0;
            string temp = "";

            if (fi.Exists)
            {
                fi.CopyTo(nfn, true);
            }

            using (StreamReader sr = new StreamReader(fn))
            {
                using (StreamWriter sw = new StreamWriter(nfn))
                {

                    while (!sr.EndOfStream)
                    {
                        temp = sr.ReadLine();
                        counter++;

                        if (index == counter)
                        {
                            sw.WriteLine(Line);
                        }
                        else
                        {
                            sw.WriteLine(temp);
                        }

                    }

                }
            }

            fi.Delete();

            fi = new FileInfo(nfn);

            if (fi.Exists)
            {
                fi.CopyTo(fn, true);
            }

            fi.Delete();

        }

    }
}
