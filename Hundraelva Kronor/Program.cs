using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundraelva_Kronor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad kostar maskinen? ");
            int pris = int.Parse(Console.ReadLine());

            int rest = pris;
            int sedlar = 0;

            while (rest != 0)
            {
                while (rest >= 111111111)
                {
                    if (pris >= 111111111)
                    {
                        rest = rest - 111111111;
                        sedlar++;
                    }
                }
                while (rest >= 11111111)
                {
                    if (pris >= 11111111)
                    {
                        rest = rest - 11111111;
                        sedlar++;
                    }
                }
                while (rest >= 1111111)
                {
                    if (pris >= 1111111)
                    {
                        rest = rest - 1111111;
                        sedlar++;
                    }
                }
                while (rest >= 111111)
                {
                    if (pris >= 111111)
                    {
                        rest = rest - 111111;
                        sedlar++;
                    }
                }
                while (rest >= 11111)
                {
                    if (pris >= 11111)
                    {
                        rest = rest - 11111;
                        sedlar++;
                    }
                }
                while (rest >= 1111)
                {
                    if (pris >= 1111)
                    {
                        rest = rest - 1111;
                        sedlar++;
                    }
                }
                while (rest >= 111)
                {
                    if (pris >= 111)
                    {
                        rest = rest - 111;
                        sedlar++;
                    }
                }
                while (rest >= 11)
                {
                    if (pris >= 11)
                    {
                        rest = rest - 11;
                        sedlar++;
                    }
                }
                while (rest >= 1)
                {
                    if (pris >= 1)
                    {
                        rest = rest - 1;
                        sedlar++;
                    }
                }


            }
            Console.WriteLine("Antal sedlar: " + sedlar);
            
        }
    }
}
