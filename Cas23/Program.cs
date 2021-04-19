using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;

            /* Nested IF */
            if (a > b)
            {
                Console.WriteLine("[IF 1.] A je vece od B");
            } else
            {
                if (a == b)
                {
                    Console.WriteLine("[IF 1.] A je jednako B");
                }
                else
                {
                    Console.WriteLine("[IF 1.] B je vece od A");
                }
            }

            /* if-else if-else */
            if (a > b)
            {
                Console.WriteLine("[IF 2.] A je vece od B");
            } else if (a < b)
            {
                Console.WriteLine("[IF 2.] B je vece od A");
            } else
            {
                Console.WriteLine("[IF 2.] A je jednako B");
            }


            int ocena = 0;

            Console.Write("Unesi ocenu (1-5) > ");

            try
            {
                ocena = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Morate uneti broj izmedju 1 i 5.");
                Console.ReadKey();
                Environment.Exit(1);
            } catch (Exception)
            {
                Console.WriteLine("Doslo je do neocekivane greske, pokusajte ponovo.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            switch (ocena)
            {
                case 1:
                    Console.WriteLine("[SWITCH] Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("[SWITCH] Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("[SWITCH] Dobar");
                    break;
                case 4:
                    Console.WriteLine("[SWITCH] Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("[SWITCH] Odlican");
                    break;
                default:
                    Console.WriteLine("[SWITCH] Uneti ocenu od 1 do 5");
                    break;
            }

            Console.ReadKey();
        }
    }
}
