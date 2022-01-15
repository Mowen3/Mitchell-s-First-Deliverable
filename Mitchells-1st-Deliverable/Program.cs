using System;

namespace Mitchells_1st_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("How many PB & J Sandwiches do you need?");
                double sandwiches = Double.Parse(Console.ReadLine());
                Console.WriteLine($"You want {sandwiches} sandwiches");
                double numOfBread = (sandwiches * 2) / 28;
                double loaves = Math.Ceiling(numOfBread);

                double numOfPB = (sandwiches * 2) / 32;
                double pb = Math.Ceiling(numOfPB);

                double numOfJelly = (sandwiches * 4) / 48;
                double jelly = Math.Ceiling(numOfJelly);

                Console.WriteLine($"You'll need {loaves} loaves");
                Console.WriteLine($"You'll need {pb} peanut butter jars");
                Console.WriteLine($"You'll need {jelly} jars of jelly");

                Console.WriteLine("Would you like to make more sandwiches");
                string answer = Console.ReadLine();
                if (!(answer == "yes" || answer == "y"))
                {
                    Console.WriteLine("Enjoy your sandwiches!");
                    break;
                }
            }

        }
    }
}
