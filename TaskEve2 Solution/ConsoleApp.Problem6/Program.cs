using System;

namespace ConsoleApp.Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib.
            // Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap.
            // Alinan cavabin kvadratini tap.

            Console.Write("4 reqemli ededi daxil edin: "); // 5678

            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------");

            bool isSuccess = a >= 1000 && a < 10000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 4 reqemli deyil");
                ;
                return;
            }

            a = a * 0.2; // Ededin 20% i

            Console.WriteLine("Ededin 20 faizi: " + a);
            Console.WriteLine("--------");

            a = a * 0.1; // Alinan ededin 10% 1

            Console.WriteLine("Alinan ededin 10 faizi: " + a);
            Console.WriteLine("--------");

            a = a * a; // Yeni ededin kvadrati

            Console.WriteLine("Yeni ededin kvadrati: " + a);



        }
    }
}
