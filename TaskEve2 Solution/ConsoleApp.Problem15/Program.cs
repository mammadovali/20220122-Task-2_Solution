using System;

namespace ConsoleApp.Problem15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
            //3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            //Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            //Sonra alinan cavabin ustune gel 6 reqemli ededi.
            //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            //Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
            //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.

            Console.Write("Birici 3 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ikinci 3 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Birici 4 reqemli ededi daxil edin: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ikinci 4 reqemli ededi daxil edin: ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Birici 5 reqemli ededi daxil edin: ");
            double e = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.Write("6 reqemli ededi daxil edin: ");           
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------");

            bool isSuccess1 = a >= 100 && a < 1000 && b >= 100 && b < 1000;
            bool isSuccess2 = c >= 1000 && c < 10000 && d >= 1000 && d < 10000;
            bool isSuccess3 = e >= 10000 && e < 100000 && f >= 10000 && f < 1000000;
            bool isSuccess4 = g >= 100000 && g < 1000000;

            if (!(isSuccess1 && isSuccess2 && isSuccess3 && isSuccess4))
            {
                Console.WriteLine("Ededler verilen shertlere uygun daxil edilmeyib ");
                return;
            }

            double x = a + b; //3 reqemli ededlerin cemi
            Console.WriteLine("3 reqemli ededlerin cemi: " + x);
            Console.WriteLine("--------");

            double y = c * d; //4 reqemli ededlerin hasili
            Console.WriteLine("4 reqemli ededlerin hasili: " + y);
            Console.WriteLine("--------");

            double z = x + y; // 3 reqemli ededlerin cemi ile 4 reqemli ededlerin hasilinin toplami
            Console.WriteLine("3 reqemli ededlerin cemi ile 4 reqemli ededlerin hasilinin toplami: " + z);
            Console.WriteLine("--------");

            z = z * 10 + 7; // neticenin sonuna 7 reqemi elave edildi
            Console.WriteLine("Alinan cavabin sonuna 7 reqemi elave edildi: " + z);
            Console.WriteLine("--------");

            z = z + e + f; // Alinan cavabin uzerine 5 reqemli ededler elave olundu
            Console.WriteLine("Alinan cavabin uzerine 5 reqemli ededler elave olundu: " + z);
            Console.WriteLine("--------");

            double l = (a * b) * 10 + 1; // 3 reqemli ededlerin hasilinin sonuna 1 artirilmish variant
            Console.WriteLine("3 reqemli ededlerin hasilinin sonuna 1 artirilmish variant: " + l);
            Console.WriteLine("--------");

            z -= l; // 

            Console.WriteLine("Bir onceki alinan neticeden 3 reqemli ededlerin hasilinin sonuna 1 elave edilmish varianti cixildi: " + z);
            Console.WriteLine("--------");

            z += g; // Neticenin uzerine 6 reqemli eded gelindi;
            Console.WriteLine("Neticenin uzerine 6 reqemli eded gelindi: " + z);
            Console.WriteLine("--------");

            z = z - (a + b + c + d); //Alinan cavabdan 3 ve 4 reqemli ededlerin cemi cixildi
            Console.WriteLine("Alinan cavabdan 3 ve 4 reqemli ededlerin cemi cixildi: " + z);
            Console.WriteLine("--------");

            z *= 0.18; // Yekun neticenin 18% i
            Console.WriteLine("Yekun neticenin 18% i: " + z);
            Console.WriteLine("--------");

            z *= 0.03; // Alinan ededin 3% i
            Console.WriteLine("Alinan ededin 3% i: " + z);
            Console.WriteLine("--------");

            z *= 0.01; // Neticenin 1% i
            Console.WriteLine("Neticenin 1% i: " + z);
            Console.WriteLine("--------");

            z += (e + f); // Son netice ile 5 reqemleri ededlerin ceminin toplami
            Console.WriteLine("Son netice ile 5 reqemleri ededlerin ceminin toplami: " + z);

            








        }
    }
}
