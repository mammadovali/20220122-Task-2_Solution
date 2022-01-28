using System;

namespace ConsoleApp.Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib.
            // Bu ededin evveline 4 reqemi , axirina ise 44 ededini artir.
            // Alinan cavabin 44 % tap.

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

            double newNumber = a + 40000; // 45678

            a = newNumber * 100 + 44; // 4567844

            Console.WriteLine("Ededin evveline 4, sonuna ise 44 artirildi: " + a);
            Console.WriteLine("--------");

            a = a * 0.44; // (4567844 * 40) / 100

            Console.WriteLine("Alinan yeni ededin 44% i: " + a);




        }
    }
}
