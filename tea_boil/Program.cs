using System;
using System.Threading.Tasks;

namespace tea_boil
{
    class Program
    {
        static void Main(string[] args)
        {
            // uvařit vodu
            string water = BoilWater();

            // nachystáme hrnky a do hrnků dáme čaj
            string cups = PrepareCups(2);

            // do hrnků nalijeme horkou vodu
            Console.WriteLine($"Nalévám {water} do {cups}");
            Console.WriteLine("Luhování čaje");
            Task.Delay(3000).Wait();

            // horké mléko do čaje
            var warmMilk = WarmupMilk();
            Console.WriteLine($"Přidávám {warmMilk} do {cups}");

            Console.WriteLine("Čaj s mlékem je připravený");

            Console.ReadLine();
        }

        static string BoilWater()
        {
            Console.WriteLine("Vodu nalijeme do konvice");
            Console.WriteLine("Zapneme ohřev vody");
            Task.Delay(3000).Wait();
            Console.WriteLine("Voda vře");

            return "horkou vodu";
        }

        static string PrepareCups(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                Console.WriteLine($"Přichystám hrnek č. #{i + 1}");
                Task.Delay(2000).Wait();
                Console.WriteLine($"Do hrnku vložíme čaj");
                Task.Delay(1000).Wait();
            }


            return "hrnků s čajem";
        }

        static string WarmupMilk()
        {
            Console.WriteLine("Vložení mléka do nádoby");
            Console.WriteLine("Vložení mléka do mikrovlnky");
            Console.WriteLine("Ohřívání mléka");
            Task.Delay(3000).Wait();

            Console.WriteLine("Ohřívání mléka dokončeno");

            return "Horké mléko";
        }
    }
}
