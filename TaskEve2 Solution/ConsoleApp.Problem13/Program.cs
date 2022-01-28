using System;

namespace ConsoleApp.Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
            // 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
            // Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla.
            // Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.

            Console.Write("Birinci 5 reqemli ededi daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ucuncu 5 reqemli ededi daxil edin: ");
            double c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Birinci 3 reqemli ededi daxil edin: ");
            double d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 3 reqemli ededi daxil edin: ");
            double e = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000;
            bool isSuccess1 = d >= 100 && d < 1000 && e >= 100 && e < 1000;

            if (!(isSuccess && isSuccess1))
            {
                Console.WriteLine("Daxilen edilen ededler shertlere uygun deyil !");
                return;
            }

            a *= 0.05; // Birinci 5 reqemli ededin 5 faizi
            Console.WriteLine("Birinci 5 reqemli ededin 5% i: " + a);
            Console.WriteLine("--------");

            b *= 0.05; // Ikinci 5 reqemli ededin 5 faizi
            Console.WriteLine("Ikinci 5 reqemli ededin 5% i: " + b);
            Console.WriteLine("--------");

            c *= 0.05; // Ikinci 5 reqemli ededin 5 faizi
            Console.WriteLine("Ucuncu 5 reqemli ededin 5% i: " + c);
            Console.WriteLine("--------");

            double x = a * b * c; // 5 reqemli ededlerin 5% nin hasili
            Console.WriteLine("5 reqemli ededlerin 5% nin hasili: " + x);
            Console.WriteLine("--------");

            d *= 0.03; // Birinci 3 reqemli ededin 3 faizi
            Console.WriteLine("Birinci 3 reqemli ededin 3% i: " + d);
            Console.WriteLine("--------");

            e *= 0.03; // Ikinci 3 reqemli ededin 3 faizi
            Console.WriteLine("Ikinci 3 reqemli ededin 3% i: " + e);
            Console.WriteLine("--------");

            double y = d + e; // 3 reqemli ededlerin 3% nin cemi
            Console.WriteLine("3 reqemli ededlerin 3% nin cemi: " + y);
            Console.WriteLine("--------");

            x *= 0.1; // 5 reqemli ededlerin 5% nin hasilinin 10% i
            Console.WriteLine("5 reqemli ededlerin 5% nin hasilinin 10% i: " + x);
            Console.WriteLine("--------");

            y *= 0.1; // 3 reqemli ededlerin 3% nin ceminin 10% i
            Console.WriteLine("3 reqemli ededlerin 3% nin ceminin 10% i: " + y);
            Console.WriteLine("--------");

            double z = x + y; // Alinan son 2 cavabin cemi
            Console.WriteLine("Alinan son 2 cavabin cemi: " + z);




        }
    }
}
