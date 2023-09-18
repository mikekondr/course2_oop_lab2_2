using System;
using System.IO;
using System.Windows.Forms;

namespace task9
{
    internal class Ar
    {
        //закриті поля класу
        private int n;
        private int[] a;

        //конструктор 1 - заповнення випадковими числами
        public Ar(int num, int from, int to)
        {
            n = num;
            a = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(from, to);
        }

        //конструктор 2 - заповнення з файлу
        public Ar(string filename)
        {
            if (File.Exists(filename) == false)
                throw new FileNotFoundException();

            string str = "";
            n = 0;
            try
            {
                StreamReader f = new StreamReader(filename);
                if (!f.EndOfStream)
                    str = f.ReadLine();
                f.Close();
            }
            catch
            {
                throw new FileLoadException();
            }

            string[] parts = str.Split('.');
            n = parts.Length;
            a = new int[n];

            for (int i = 0; i < parts.Length; i++)
                int.TryParse(parts[i], out a[i]);
        }

        //геттер (властивість): кількість від'ємних значень
        public int K
        {
            get
            {
                int k = 0;
                for (int i = 0; i < n; i++)
                    if ( a[i] < 0 ) k++;
                return k;
            }
        }

        //геттер (властивість): кількість елементів
        public int N
        {
            get => n;
        }

        //метод виводу елементів у список ListBox
        public void Print(ListBox lst)
        {
            lst.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                lst.Items.Add("[" + i.ToString() + "]: " + a[i].ToString());
            }
        }

        //метод пошуку останнього від'ємного елементу
        public int P()
        {
            int t = -1;
            for (int i = n-1; i >= 0; i--)
                if (a[i] < 0 )
                {
                    t = i; break;
                }
            return t;
        }

        //метод сумування елементів з індексами від
        //i1 до i2 включно
        public int Sum(int i1, int i2)
        {
            int sum = 0;
            for (int i = i1; i <= i2; i++)
                sum += a[i];
            return sum;
        }
    }
}