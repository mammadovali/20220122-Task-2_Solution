using System;

namespace ConsoleApp.Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2) 3 reqemli eded verilib.
            // Bu ededin axirina hemin ededdin ozunu yapishdir.
            // example: 333= 333333

            Console.Write("3 reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100 && a < 1000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 3 reqemli deyil !");
                return;
            }

            int lastNumbers = a * 1000; // 333000
            a = lastNumbers + a;
            Console.WriteLine("Ededin sonuna ededin ozunu yapisdirqida alinan netice: " + a);

        }
    }
}
