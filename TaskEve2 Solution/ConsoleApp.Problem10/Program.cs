using System;

namespace ConsoleApp.Problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
            //Neticeleri bir birinden cix.
            //Alinan cavabin ustune III ededin 7 % faizini gel.

            Console.Write("Birinci 4 reqemli ededi daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 4 reqemli ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ucuncu 4 reqemli ededi daxil edin: ");
            double c = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000;

            if (!isSuccess)
            {
                Console.WriteLine("Ededlerin hamisi 4 reqemli deyil");
                return;
            }

            a = a * 0.01; // birinci ededin 1% i
            Console.WriteLine("Birinci ededin 1% - i: " + a);
            Console.WriteLine("--------");

            b = b * 0.02;  // ikinci ededin 2% i
            Console.WriteLine("Ikinci ededin 2% - i: " + b);
            Console.WriteLine("--------");

            double c1 = c * 0.07; // ucuncu ededin 7 faizi 

            c = c * 0.03; // ucuncu ededin 3% i
            Console.WriteLine("Ucuncu ededin 3% - i: " + c);
            Console.WriteLine("--------");

            double d = a - b - c; // yeni ededlerin ferqi 
            Console.WriteLine("Yeni ededlerin ferqi: " + d);
            Console.WriteLine("--------");

            d = d + c1; // yeni ededlerin ferqi + ucuncu ededin 7 faizi

            Console.WriteLine("Yeni ededlerin ferqinin uzerine 3-cu ededin 7% - ni geldikde alinan cavab: " + d);

          

            
        }
    }
}
