using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un mois pour que je vous indique le saison correspondante");
            string mois = Console.ReadLine();

            switch(mois)
            {
                case "Janvier":
                case "Février":
                case "Mars":
                Console.WriteLine("C'est l'hiver");
                break;
                case "Juin":
                case "Mai":
                case "Avril":
                Console.WriteLine("C'est le printemps");
                break;
                case "Juillet":
                case "Aout":
                case "Septembre":
                Console.WriteLine("C'est l'été");
                break;
                case "Octobre":
                case "Novembre":
                case "Décembre":
                Console.WriteLine("C'est l'automne");
                break;
                default:
                Console.WriteLine("Je n'est pas saisie votre saisie");
                break;
            }
        }
    }
}
