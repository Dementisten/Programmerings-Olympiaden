using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange personnummer: ");
            string pnummer = Console.ReadLine();

            int first = int.Parse(pnummer.Substring(0, 1));

            bool minus = (pnummer.Contains("-"));

            if (minus == true)
            {
                if (first > 2)
                    Console.WriteLine("19" + pnummer.Remove(6, 1));
                else
                    Console.WriteLine("20" + pnummer.Remove(6, 1));

            }

            if (minus == false) 
            {
                if (first <= 1)
                    Console.WriteLine("19" + pnummer.Remove(6, 1));
                else
                    Console.WriteLine("18" + pnummer.Remove(6, 1));

            }
            
            
            
        }
    }
}
