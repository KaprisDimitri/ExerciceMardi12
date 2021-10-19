using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int life;
            Console.WriteLine("Rentrer la vie du joueur");
            if(int.TryParse(Console.ReadLine(), out life))
            {
                
                if(life <=20 && life >= 1)
                {
                    Console.WriteLine("ROUGE");
                }
                else if (life <=40 && life >= 21)
                {
                    Console.WriteLine("ORANGE");
                }
                else if (life <= 60 && life >= 41)
                {
                    Console.WriteLine("JAUNE");
                }
                else if (life >61)
                {
                    Console.WriteLine("VERT");
                }
                else
                {
                    Console.WriteLine("NOIR");
                }
            }
            else
            {
               
                Console.WriteLine("Saisie non valide veuillez relancer le programme");
            }

            
        }
    }
}
