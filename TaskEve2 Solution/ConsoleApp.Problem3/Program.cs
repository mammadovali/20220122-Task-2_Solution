using System;

namespace ConsoleApp.Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.

            Console.Write("5 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
           

            bool isSuccess = a >= 10000 && a < 100000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 5 reqemli deyil");
                return;
            }

            a = a * 0.18; // daxil edilen ededin 18% i
            Console.WriteLine("Ededin 18% i: " + a);

            a /= 6; // ededin 3% i

            Console.WriteLine("Ededin 3% i: " + a);
        }
    }
}
