using System;

namespace ExoAgeDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez saisir nom prénom");
            string useurName = Console.ReadLine();
            Console.WriteLine("Quel age avez vous "+ useurName +"?");
            string age = Console.ReadLine();
            if(int.TryParse(age, out int result))
            {
                if(result > 0 && result < 120)
                {
                    int birthYear = DateTime.Now.Year - result;
                 Console.WriteLine("Vous êtes né en " + birthYear +" "+ useurName +" si vous avez vraiment " +result+ " ans.");
                }
                else
                {
                    Console.WriteLine("ca ne peut pas etre votre age");
                }
            }
            else
            {
                Console.WriteLine("ca ne peut pas etre votre age");
            }
            
            
             /*Console.WriteLine("Bienvenue sur notre programme, tapez votre nom :");
             string nomUtilisateur = Console.ReadLine() ;
             Console.WriteLine("Bonjour "+nomUtilisateur+" !\nTapez votre age svp :");
            string age = Console.ReadLine() ;
             int BirthYear = DateTime.Now.Year - int.Parse(age);
             Console.WriteLine("Vous êtes né l'année : "+BirthYear+" et vous avez "+age+" ans" );*/
        }
    }
}
