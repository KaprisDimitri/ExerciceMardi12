using System;

namespace Exercice8
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
                    Console.WriteLine("Micro tremblement de terre, non ressenti");
                   break;
                   case 2:
                    Console.WriteLine("Très mineur. non ressenti mais détecté");
                   break;
                   case 3:
                    Console.WriteLine("Mineur. causant rarement des dommages");
                   break;
                   case 4:
                    Console.WriteLine("Léger. Secousses notables d’objets à l’intérieur des maisons");
                   break;
                   case 5:
                    Console.WriteLine("Modéré. Légers dommages aux édifices bien construits");
                   break;
                   case 6:
                    Console.WriteLine("Fort. Destructeur dans des zones allant jusqu’à 180 kilomètres à la ronde si elles sont peuplées");
                   break;
                   case 7:
                    Console.WriteLine("Majeur. Dommages modérés à sévères dans des zones plus vastes.");
                   break;
                   case 8:
                    Console.WriteLine("Important. Dommages sérieux dans des zones à des centaines de kilomètres à la ronde");
                   break;
                   case 9:
                    Console.WriteLine("Dévastateur.Dévaste des zones sur des milliers de kilomètres à la ronde");
                   break;
                   
                   default:

                   if (chiffre <1)
                   {
                        Console.WriteLine("erreur de saisie");
                   }
                   else if (chiffre >9)
                   {
                       Console.WriteLine("C'est l'apocalypse");
                   }
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
