using System;

namespace TabliceMatematyczne
{
    class Program
    {
        static int wzor1(int a, int b, int h)
        {
            return ((a + b) / 2) * h;
        }
        static int wzor2(int a, int b, int c)
        {
            return 2 * ((a * b) + (b * c) + (a * c));

        }
        static double wzor3(double n, double k)
        {
            return Math.Pow(n, k);


        }
        static void Main(string[] args)
        {
            int wybor;
            Console.WriteLine("TABLICE MATEMCZYNE");
            do
            {
                Console.WriteLine("1---Oblicz pole trapezu");
                Console.WriteLine("2---Oblicz pole powierzchni całkowite prostopadłościanu");
                Console.WriteLine("3---Oblicz wariacje bez powtórzeń");
                Console.WriteLine("0---wyjście");
                wybor = Convert.ToInt32(Console.ReadLine());

                if (wybor == 1)
                {
                    int a, b, h;
                    Console.WriteLine("Podaj długość podstawy:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj długość drugiej podstawy:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj wysokość:");
                    h = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pole wynosi :{0}", wzor1(a, b, h));
                }
                else if (wybor == 2)
                {
                    int a, b, c;
                    Console.WriteLine("Podaj długość boku a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj długość boku b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj długość boku c:");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pole całkowite wynosi :{0}", wzor2(a, b, c));
                }
                else if (wybor == 3)
                {
                    double n, k;
                    Console.WriteLine("Podaj liczbe elementów :");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj z ilu składa się jeden element:");
                    k = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wariacja wynosi :{0}", wzor3(n, k));
                }
            }
            while (wybor != 0);
        }
    }
}
