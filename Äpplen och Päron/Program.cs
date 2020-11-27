using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många äpplen har Axel sålt? ");
            int Axel = int.Parse(Console.ReadLine());

            Console.Write("Hur många päron har Petra sålt? ");
            int Petra = int.Parse(Console.ReadLine());

            int axelsumma = Axel * 7;
            int petrasumma = Petra * 13;

            if (axelsumma > petrasumma)
                Console.WriteLine("Axel");
            else if (axelsumma < petrasumma)
                Console.WriteLine("Petra");
            else
                Console.WriteLine("Lika");
        }
    }
}
