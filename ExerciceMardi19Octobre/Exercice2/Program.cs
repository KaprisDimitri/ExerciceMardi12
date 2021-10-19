using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if(int.TryParse(Console.ReadLine(), out int a))
            {
                 if(a % 2 == 0)
                 {
                     Console.WriteLine("Votre saisie est un nombre paire");
                 }
                 else
                 {
                      Console.WriteLine("Votre saisie est un nombre impaire");
                 }
            }
            else
            {
                Console.WriteLine("Problème de saisie veuillez recommencer le programme");
            }
            
            
        }
    }
}
