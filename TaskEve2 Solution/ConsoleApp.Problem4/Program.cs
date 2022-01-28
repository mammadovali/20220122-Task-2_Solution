using System;

namespace ConsoleApp.Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 reqemli eded verilib.
            // Bu ededin axirina 7 artir.
            // Sonra cavabin 7 % tap;

            Console.Write("3 reqemli ededi daxil edin: "); //123
            double a = Convert.ToDouble(Console.ReadLine());

            bool isSuccess = a >= 100 && a < 1000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 3 reqemli deyil !");
                return;
            }

            double lastNumber = a * 10; // 1230

            a = lastNumber + 7; // 1237

            Console.WriteLine("Ededin sonuna 7 artirildi: " + a);

            a = a * 0.07; // Ededin 7 faizi

            Console.WriteLine("Yeni ededin 7 faizi: " + a);
        } 
    }
}
