using System;

namespace ConsoleApp.Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 dene 6 reqemli eded verilib. Evvel hamisini topla .
            // Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            // I neticeden II neticeni cix.Alinan cavabin 10 % tap.
            // Neticenin uzerine V ve VI ededleri gel.
            // Yekunda alinan cavabin 11 % tap.

            Console.Write("Birinci 6 reqemli ededi daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 6 reqemli ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ucuncu 6 reqemli ededi daxil edin: ");
            double c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dorduncu 6 reqemli ededi daxil edin: ");
            double d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Beshinci 6 reqemli ededi daxil edin: ");
            double e = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altinci 6 reqemli ededi daxil edin: ");
            double f = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 100000 && e < 1000000;

            if (!isSuccess)
            {
                Console.WriteLine("Daxilen edilen ededlerin hamisi 6 reqemli deyil !");
                return;
            }

            double x = a + b + c + d + e + f; //ededlerin cemi

            Console.WriteLine("Ededlerin cemi: " + x);
            Console.WriteLine("--------");

            a = (a * 1000000) + c; // birinci ededle ucuncu ededin birleshimi

            Console.WriteLine("1ci ededle 3cu ededin birleshimi: " + a);
            Console.WriteLine("--------");

            double y = x - a; // Butun verilen ededlerin cemi ile 1 ve 3 cu ededlerin bitrleshiminin ferqi

            Console.WriteLine("Butun verilen dedlerin cemi ile 1 ve 3 cu ededlerin bitrleshiminin ferqi: " + y);
            Console.WriteLine("--------");

            y *= 0.1; // Alinan neticenin 10% i

            Console.WriteLine("Alinan neticenin 10% - i: " + y);
            Console.WriteLine("--------");

            y = y + d + e; // Alinan cavab, 4 ve 5 ci ededlerin toplami 

            Console.WriteLine("Alinan cavab, 4 ve 5 ci ededlerin toplami: " + y);
            Console.WriteLine("--------");

            y *= 0.11; // Yekun neticenin 11% i

            Console.WriteLine("Yekun neticenin 11% i: " + y);
        }
    }
}
