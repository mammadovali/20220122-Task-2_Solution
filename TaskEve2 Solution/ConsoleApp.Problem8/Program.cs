using System;

namespace ConsoleApp.Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene eded verilib.I eded 4 reqemli II eded 7 reqemlidir.
            // I ededin 4 % -ni tap.
            // Sonra II ededin 9 % ni tap.
            // Sonra Cavalari toplayib 10 % ni tap.

            Console.Write("4 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("--------");

            Console.Write("7 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("--------");

            bool isSuccess = a >= 1000 && a < 10000 && b >= 1000000 && b < 10000000;

            if (!isSuccess)
            {
                Console.WriteLine("Ededler shertlere uygun daxil edilmeyib");
                return;
            }

            a = a * 0.04;  // birinci ededin 4 faizi (4 reqemli)

            Console.WriteLine("4 reqemli ededin 4% i: " + a);
            Console.WriteLine("--------");

            b = b * 0.09;  // ikinci ededin 9 faizi (7 reqemli)

            Console.WriteLine("7 reqemli ededin 9% i: " + b);
            Console.WriteLine("--------");

            double c = a + b; // birinci ededin 4 faizi ile ikinci ededin 9 faizinin cemi

            Console.WriteLine("Yeni ededlerin cemi: " + c);
            Console.WriteLine("--------");

            c = c * 0.1; // cemin 10 faizi

            Console.WriteLine("Yeni ededlerin ceminin 10% i: " + c);




        }
    }
}
