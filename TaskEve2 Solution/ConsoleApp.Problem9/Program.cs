using System;

namespace ConsoleApp.Problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 6 reqemli eded verilib.
            // Her birinin 10 faizini tapib neticeleri topla.
            // Alinan cavabin 10 % tap.

            Console.Write("Birinci 6 reqemli ededi daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine()); 
            
            Console.Write("Ikinci 6 reqemli ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ucuncu 6 reqemli ededi daxil edin: ");
            double c  = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000;

            if (!isSuccess)
            {
                Console.WriteLine("Ededlerin hamisi 6 reqemli deyil");
                return;
            }

            a = a * 0.1; // birinci ededin 10% i
            Console.WriteLine("Birinci ededin 10% i:" + a);
            Console.WriteLine("--------");

            b = b * 0.1;  // ikinci ededin 10% i
            Console.WriteLine("Ikinci ededin 10% i:" + b);
            Console.WriteLine("--------");

            c = c * 0.1; // ucuncu ededin 10% i
            Console.WriteLine("Ucuncu ededin 10% i:" + c);
            Console.WriteLine("--------");

            double d = a + b + c; // yeni ededlerin cemi
            Console.WriteLine("Yeni ededlerin cemi: " + d);
            Console.WriteLine("--------");

            d = d * 0.1; // alinan cavabin 10% i

            Console.WriteLine("Alinan cavabin 10% i: " + d);

            
            

        }
    }
}
