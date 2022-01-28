
using System;

namespace ConsoleApp.Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

              4 reqemli eded verilib.
              Bu ededin evveline 7 reqemini,
              axirina da 8 reqemini artir 
              Example : 3333 -> 73338

             */

            Console.Write("4 reqemli ededi daxil edin: ");  //3333
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 1000 && a < 10000;

            if (!isSuccess)
            {
                Console.WriteLine("Daxil edilen eded 4 reqemli deyil !");
                return;
            }

            int newNumber = a * 10 + 8; // 33338
            newNumber += 700000;

            Console.WriteLine("Ededin evveline 7, sonuna 8 elave etdikde alinan netice:  " + newNumber);


        }
    }
}
