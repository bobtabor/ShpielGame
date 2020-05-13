using System;

namespace ShpielGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Make a Shpiel!");
            Console.Write("Do you want the prize behind Door 1, 2 or 3? ");
            string response = Console.ReadLine();

            if (response == "1") {
                Console.WriteLine("You won a car!");
            } else if (response == "2") {
                Console.WriteLine("You won a boat");
            } else if (response == "3") {
                Console.WriteLine("You won a motorcycle!");
            } else {
                Console.WriteLine("You had one job: 1, 2 or 3 ... you LOSE!");
                Console.Beep();
            }
        }
    }
}
