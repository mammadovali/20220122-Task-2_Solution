using System;

namespace ConsoleApp.Problem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla.
            // Sonra hamisinin 15 faizini tap ve topla.
            // Sonra yekunda alinanlar iki cavabi vur biri birine.
            // Alinan neticenin evvel 10 % tap
            // sonra ise hemin cavabin 11 % tap.

            Console.Write("Birinci 6 reqemli eded: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ikinci 6 reqemli eded: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ucuncu 6 reqemli eded: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dorduncu 6 reqemli eded: ");
            double d = Convert.ToDouble(Console.ReadLine());

            bool isSuccess = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000;

            if (!isSuccess)
            {
                Console.WriteLine("Ededlerin hamisi 6 reqemli deyil !");
                return;
            }

            a *= 0.1; // Birinci 6 reqemli ededin 10% i
            Console.WriteLine("Birinci 6 reqemli ededin 10% i: " + a);
            Console.WriteLine("--------");

            b *= 0.1; // Ikinci 6 reqemli ededin 10% i
            Console.WriteLine("Ikinci 6 reqemli ededin 10% i: " + b);
            Console.WriteLine("--------");

            c *= 0.1; // Ucuncu 6 reqemli ededin 10% i
            Console.WriteLine("Ucuncu 6 reqemli ededin 10% i: " + c);
            Console.WriteLine("--------");

            d *= 0.1; // Dorduncu 6 reqemli ededin 10% i
            Console.WriteLine("Dorduncu 6 reqemli ededin 10% i: " + d);
            Console.WriteLine("--------");

            double x = a + b + c + d; // Alinan ededlerin cemi
            Console.WriteLine("Alinan ededlerin cemi: " + x);
            Console.WriteLine("--------");

            a = a * 0.5 + a; // Birinci 6 reqemli ededin 15% i
            Console.WriteLine("Birinci 6 reqemli ededin 15% i: " + a);
            Console.WriteLine("--------");

            b = b * 0.5 + b; // Ikinci 6 reqemli ededin 15% i
            Console.WriteLine("Ikinci 6 reqemli ededin 15% i: " + b);
            Console.WriteLine("--------");

            c = c * 0.5 + c; // Ucuncu 6 reqemli ededin 15% i
            Console.WriteLine("Ucuncu 6 reqemli ededin 15% i: " + c);
            Console.WriteLine("--------");

            d = d * 0.5 + d; // Dorduncu 6 reqemli ededin 15% i
            Console.WriteLine("Dorduncu 6 reqemli ededin 15% i: " + d);
            Console.WriteLine("--------");

            double y = a + b + c + d; // Ilkin ededlerin 15% nin toplami
            Console.WriteLine("Ilkin ededlerin 15% nin toplami: " + y);
            Console.WriteLine("--------");

            double z = x * y; // Ededlerin 10 ve 15 faizlerinin ceminin hasili
            Console.WriteLine("Ededlerin 10 ve 15 faizlerinin ceminin hasili: " + z);
            Console.WriteLine("--------");

            z *= 0.1; // Yekun neticenin 10% i
            Console.WriteLine("Yekun neticenin 10% i: " + z);
            Console.WriteLine("--------");

            z *= 0.11; // Alinan cavabin 11% i
            Console.WriteLine("Alinan cavabin 11% i: " + z);










        }
    }
}
