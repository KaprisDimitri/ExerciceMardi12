using System;

namespace Exercice3
{
    
    class Program
    {
        static int playerHealth = 100;
         static bool invincible = false;
         static int damage = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Tapez le nombre de domage que l'ennemie inflige");
            if(int.TryParse(Console.ReadLine(), out damage))
            {
              Console.WriteLine("Voulez vous que votre joueur soit invincible ? si oui tapez 1 si non tapez 0");
              if(int.TryParse(Console.ReadLine(), out int result))
              {
                  if(result == 1)
                  {
                      invincible = true;
                  }
                  else if (result == 0)
                  {
                      invincible = false;
                  }
                  else 
                  {
                      Console.WriteLine("Saisie erroné votre joueur n'aura pas l'invncibilité");
                  }

                  if (invincible == false)
                  {
                playerHealth = damageE();
                Console.WriteLine("Le joueur a " + playerHealth +"PV");

                  }
                  else
                  {
                   Console.WriteLine("Le joueur n'as pris aucun degat car le mode invincible est acitvé");
                  }
              }
              else
              {
                  Console.WriteLine("Saisie erroné Veuillez recommencer le programme");
              }
            }
            else
            {
                 Console.WriteLine("La saisie est erroné veuillez recommencer le programme");
            }
        }

        public static int damageE()
        {
             playerHealth = playerHealth - damage;
             return playerHealth;
        }
    }
}
