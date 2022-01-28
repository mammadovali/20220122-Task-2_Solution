using System;

namespace ConsoleApp.Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  2 dene 5 reqemli eded verilib.
            //  Bu ededleri toplayib alinan cavabin evveline ve axirina 5 artir.
            //  Neticenin 5 % tap.
           
            Console.Write("Birinci 5 reqemli ededi daxil edin: ");     
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 10000 && a < 100000 && b >= 10000 && b < 100000;

            if (!isSuccess)
            {
                Console.WriteLine("Daxil edilen eded ve ya ededler 5 reqemli deyil");
                return;
            }

            double c = a + b;

            Console.WriteLine("Ededlerin cemi: " + c);
            Console.WriteLine("--------");

            if ( c >= 10000 && c < 100000)
            {
                c += 500000;
                Console.WriteLine("Cemin evveline 5 reqemi artirildi:" + c);               
            }

            else if (c >= 100000 && c < 1000000)
            {
                c += 5000000;
                Console.WriteLine("Cemin evveline 5 reqemi artirildi:" + c);
                
            }

            c = c * 10 + 5; // Cemin sonuna 5 artirildi
            Console.WriteLine("Cemin sonuna 5 artirildi: " + c);
            Console.WriteLine("--------");

            c *= 0.05; // Neticenin 5% i 
            Console.WriteLine("Neticenin 5% i: " + c);



            


        }
    }
}
