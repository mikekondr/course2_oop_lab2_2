namespace example;

public class Ar
{
    //приватні поля
    private int n; //кількість чисел в масиві
    private int[] a; //одновимірний масив
    private int ko; //кількість відʼємних чисел в масиві

    //конструктор-1
    public Ar(int num, int x)
    {
        //створюємо одновимірний масив, розміром n
        n = num; a = new int[n];
        Random rnd = new Random();
        //заповнюємо масив випадковими числами
        for (int i = 0; i < n; i++)
            a[i] = rnd.Next(-x, x);
    }

    //конструктор-2
    //заповнює масив числами з текстового файлу
    //по одному числу на кожному рядку
    public Ar(string filename)
    {
        StreamReader f = new StreamReader(filename);
        n = 0;

        //рахуємо кількість рядків
        while (f.EndOfStream != true)
        {
            f.ReadLine(); n++;
        }
        f.Close();

        //створюємо порожній масив з n елементів
        a = new int[n];

        //читаємо файл знову та заповнюємо масив
        f = new StreamReader(filename);
        for (int i = 0; i < n; i++)
            a[i] = Convert.ToInt32(f.ReadLine());
        f.Close();
    }

    //геттер (властивість) повертає кількість елементів
    public int N
    {
        get => n;
    }

    //геттер (властивість) для обчислення кількості відʼємних елементів
    public int Ko
    {
        get
        {
            ko = 0;
            for (int i = 0; i < n; i++)
                if (a[i] < 0) ko++;
            return ko;
        }
    }

    //метод виводить масив на екран
    public void Print()
    {
        Console.WriteLine();
        for (int i = 0; i < n; i++)
            Console.Write(" {0} ", a[i]);
        Console.WriteLine();
    }

    //метод повертає індекс максимального елементу
    public int Max()
    {
        int t = 0; int m = a[0];
        for (int i = 1; i < n; i++)
            if (a[i] > m)
            {
                m = a[i];
                t = i;
            }
        return t;
    }

    //метод обчислює добуток елементів масиву
    //з індексами від i1 до i2 включно
    public int Pr(int i1, int i2)
    {
        int p = 1;
        for (int i = i1; i <= i2; i++)
            p = p * a[i];
        return p;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //описуємо обʼєкт
        Ar mas;

        //обираємо конструктор
        Console.Write("Конструктор 1/2 -->  ");
        int r = Convert.ToInt32(Console.ReadLine());
        if (r == 1) //конструктор 1 - заповнення випадковими числами
        {
            Console.Write("Кількість чисел -->  ");
            int k = Convert.ToInt32(Console.ReadLine());
            mas = new Ar(k, 10);
        }
        else //конструктор 2 - заповнення чисел з файлу
        {
            //якщо файл не існує - створюємо його
            if (File.Exists("data.txt") == false)
                CreateDataFile("data.txt");
            mas = new Ar("data.txt");
        }

        //виводимо на екран елементи масиву
        mas.Print();

        //знаходимо кількість відʼємних
        int t = mas.Ko;
        Console.WriteLine("Кількість відʼємних = {0}", t);

        //знаходимо індекс максимального
        int nmx = mas.Max();
        Console.WriteLine("Індекс максимального {0}", nmx);

        // якщо максимальний не останній
        if (nmx != mas.N - 1)
        {
            //знаходимо добуток чисел правіше максимального
            int p = mas.Pr(nmx + 1, mas.N - 1);
            Console.WriteLine("Pr = {0}", p);
        }
        else
            Console.WriteLine("Максимальний елемент є останнім. Добуток не обчислюється");
    }

    static void CreateDataFile(string filename)
    {
        StreamWriter f = new StreamWriter(filename);
        f.WriteLine("8");
        f.WriteLine("-45");
        f.WriteLine("200");
        f.WriteLine("60");
        f.WriteLine("5");
        f.WriteLine("20");
        f.WriteLine("-1");
        f.Close();
    }
}

