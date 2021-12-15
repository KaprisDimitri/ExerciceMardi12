using System;

namespace _05DmStructure
{
    class Program
    {
        
        static void Main(string[] args)
        {
              
           //fonction qui lance les fonction pour trouver un mois une saison
              MoisEnum.FonctionDeDemaragePourLesMois();
              // lancement des vecteur
              FonctionDeDémarageDesVecteur();
              // limitation pour les touche a appuié
              ToucheTaper();
            

        }

//Creation des Vecteur et utilisation de ces fonction
        static void FonctionDeDémarageDesVecteur()
        {
            Vector.Vector3 vecteur1 = new Vector.Vector3(2,5,1);
            Vector.Vector3 vecteur2 = new Vector.Vector3(100,20,0);
            double dist = vecteur1.Distance(vecteur2);
            double longu = vecteur1.Longueur();
            string message = HelpForme.RetourDuneStringDansUnTableauDeDeuxCase("Vecteur 1: "+ vecteur1, "Vecteur 2:"+ vecteur2);
            Console.WriteLine(message);
            message = HelpForme.RetourDuneStringDansUnTableauDeDeuxCase("Longueur: "+ longu, "Distance: "+ dist);
            Console.WriteLine(message);
            vecteur1.Translate(new Vector.Vector3(0,1,0));
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque(vecteur1.ToString()));
        }

//Fonction pour entré une consoleKey
        static void ToucheTaper()
        {
            Console.WriteLine("Tapez sur une des flèche directionnel");
            ConsoleKeyInfo key = Console.ReadKey();
            bool check = CheckDeTouche(key.Key);
            if(!check)
            {
               ToucheTaper();

            }
        }

// verification de la touche entré 
        static bool CheckDeTouche (ConsoleKey key)
        {
             switch(key)
             {
                 case ConsoleKey.UpArrow:
                 
                 case ConsoleKey.RightArrow:
                
                 case ConsoleKey.LeftArrow:
                
                 case ConsoleKey.DownArrow:
                 Console.WriteLine("Bravo vous savez appuyer sur les touches autorisées");
                 break;
                 default:
                 Console.WriteLine("entré non valide");
                 return false;
                 break;

                

             }
              return true;
        }

    }
      
}
