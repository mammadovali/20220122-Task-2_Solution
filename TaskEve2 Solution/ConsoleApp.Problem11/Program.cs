using System;

namespace ConsoleApp.Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel .
            // II ededin usutune IV ededi gel.
            // Sonra cavablari vur birbirine.
            // Alinan neticeden III ededin 3 % -ni cix.

            Console.Write("Birinci 5 reqemli ededi daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ucuncu 5 reqemli ededi daxil edin: ");
            double c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dorduncu 5 reqemli ededi daxil edin: ");
            double d = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d >= 10000 && d < 100000;

            if (!isSuccess)
            {
                Console.WriteLine("Ededlerin hamisi 5 reqemli deyil");
                return;
            }

            double e = a + c; // 1ci eded + 3cu eded
            Console.WriteLine("1-ci ededle 3-cu ededin cemi: " + e);
            Console.WriteLine("--------");

            double f = b * d; // 2ci eded * 4cu eded
            Console.WriteLine("2-ci ededle 4-cu ededin hasili: " + f);
            Console.WriteLine("--------");

            double x = e * f; // alinan iki neticenin hasili
            Console.WriteLine("Alinan iki neticenin hasili: " + x);
            Console.WriteLine("--------");

            x = x - (c * 0.03); // yekun netice - 3cu ededin 3% i
            Console.WriteLine("Yekun netice ile 3-cu ededin 3% nin ferqi: " + x);
        }
    }
}
