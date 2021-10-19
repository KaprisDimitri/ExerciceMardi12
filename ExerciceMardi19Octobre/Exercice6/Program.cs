using System;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            string annee = Console.ReadLine();
            int anneeA = int.Parse(annee);

            if (anneeA % 4 != 0)
            {
                Console.WriteLine("C'est une année non bissextile");
            }
            else if (anneeA % 4 == 0)
            {
                if (anneeA % 100 == 0 && anneeA % 400 != 0)
                {
                    Console.WriteLine("C'est une année non bissextile");
                }
                else
                {
                    Console.WriteLine("C'est une année bissextile");
                }
            }

        }
    }
}
