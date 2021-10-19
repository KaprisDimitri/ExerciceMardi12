using System;

namespace Exercice7
{
    class Program
    {
        static void Main(string[] args)
        {
        
            if(int.TryParse( Console.ReadLine(), out int chiffre))
            {
               switch(chiffre)
               {
                   case 1:
                    Console.WriteLine("UN");
                   break;
                   case 2:
                    Console.WriteLine("DEUX");
                   break;
                   case 3:
                    Console.WriteLine("TROI");
                   break;
                   case 4:
                    Console.WriteLine("QUATRE");
                   break;
                   case 5:
                    Console.WriteLine("CINQ");
                   break;
                   case 6:
                    Console.WriteLine("SIX");
                   break;
                   case 7:
                    Console.WriteLine("SEPT");
                   break;
                   case 8:
                    Console.WriteLine("HUIT");
                   break;
                   case 9:
                    Console.WriteLine("NEUF");
                   break;
                   case 0:
                    Console.WriteLine("ZERO");
                   break;
                   default:

                   Console.WriteLine("La saisie est non valide");
                   break;
               }
              
            }
             else
               {
                   Console.WriteLine("La saisie est non valide");
               }
        }
    }
}
