using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMin;
            if(int.TryParse(Console.ReadLine(), out int a))
            {
                if(int.TryParse(Console.ReadLine(), out int b))
                {
                   if(a < b)
                   {
                      numberMin = a;
                      Console.WriteLine("Le nombre minimum est de "+ numberMin);
                   }
                   else if (a > b)
                   {
                      numberMin = b;
                      Console.WriteLine("Le nombre minimum est de "+ numberMin);
                   }
                   else if (a == b)
                   {
                       Console.WriteLine("Les saisies sont les même le nombre minimum est de " + a);
                   }
                   else
                   {
                       Console.WriteLine("Il n'y a pas de minimum surment un problème dans les chiffre entré");
                   }
                }
                else
                {
                   Console.WriteLine("Problème de saisie veuillez recommencer le programme");
                }
            }
            else
            {
Console.WriteLine("Problème de saisie veuillez recommencer le programme");
            }
            

        }
    }
}
