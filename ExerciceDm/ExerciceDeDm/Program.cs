using System;
using System.Collections.Generic;

namespace ExerciceDeDm
{
    class Program
    {
        //static int num1;
        static void Main(string[] args)
        {
            int display;
            int numChara =0;
            Console.WriteLine("Bonjour " + Environment.UserName+ " Bienvenue dans ce programme");
            Console.WriteLine("Entrez un chiffre pour savoir tout les chiffre de 0 a celui ci et ses nombre paire et impaire en bonus");
            display = EnterDisplayNumber();
            DisplayAllNumber(display);
            DisplayAllPairNumber (display);
             Console.WriteLine("\nEntrer un chiffre entre 1 et 93 pour savori la touche du clavier");
           
            numChara = EnterDisplayNumber();
            while(numChara <= 1 || numChara >= 93)
           {
               Console.WriteLine("Ce numéro n'est pas dans la table d'Ascii veuillez ressaisir votre nombre");
               numChara = EnterDisplayNumber();
           }
            DisplayAllCharacter (numChara);


            Console.WriteLine("Entrer un chiffre qui est la base de votre triangle");
            int trigNum = EnterDisplayNumber();
            Displaytriangle (trigNum);
            DisplayLosange (trigNum);



        }

        static int EnterDisplayNumber()
        {
            if(int.TryParse(Console.ReadLine(), out int num))
            {
                if(num <= 0 || num>=2147483647)
                {
                    Console.WriteLine("Ce numéro n'est pas valide resaissisez le");
                EnterDisplayNumber();
                }
                else
                {
                return num;
                }
            }
            else
            {
                Console.WriteLine("Ce numéro n'est pas valide resaissisez le");
                EnterDisplayNumber();
            }
            return 0;
        }

        static int CheckIfTheNumberInTableAscii (int num)
        {
           if(num < 33 || num > 126)
           {
               Console.WriteLine("Ce numéro n'est pas dans la table d'Ascii veuillez ressaisir votre nombre");
               return 0;
           }
           if ( num >= 33 && num <= 126)
           {
               return num;
           }

           return 10;

        }

        static void DisplayAllNumber (int maxNum)
        {
            int max = 0;
           for(int i =0; i<=maxNum; i++)
           {
               Console.Write(i);
               max++;
           }
           Console.WriteLine("\nil y a donc "+ (max - 1) +" chiffre entre celui donné et 0 (0 non compris) LOGiQUE!!!");
        }

        static void DisplayAllCharacter (int maxNum)
        {

            int num = maxNum;
            List<char> chara = new List<char>();
            for(int i = 0; i<num; i++)
            {
                chara.Add(Convert.ToChar(33 + i));
            }
            Console.Write("Vous avez demandez les "+ num +" premier élément de la table d'ascii qui equivaut a ces signes :\n");
            for(int i = 0;i< num; i++)
            {
                Console.WriteLine(33+i + " : " + chara[i]);
            }
        }

        static void DisplayAllPairNumber (int num)
        {
            Console.Write("Voici tout les nombre paire de 0 a votre chiffre: ");
            for(int i = 0; i<= num; i = i+2)
            {
                Console.Write(i);
            }
            Console.Write("\nVoici tout les nombre impaire de 0 a votre chiffre: ");
            for(int i = 1; i<= num; i = i+2)
            {
                Console.Write(i);
            }

        }

        static void Displaytriangle (int num)
        {
            char chara;
            chara = Convert.ToChar(42);
            for(int i = 1; i<=num; i++)
            {

                for(int f = 1; f<=i; f++)
                {
                Console.Write(chara);
                }
                Console.WriteLine("");
            } 
        }


        static void DisplayLosange (int num)
        {
            char chara;
            chara = Convert.ToChar(42);
            int num1 = num + 1;
            int num2 = num;
            int charaMult  = 0;
            bool check = false;
          for(int f = 0; f<= num1; f++)
          {
              if(f == num && !check)
              {
                 check = true;
                 f = 0;
                 num1 = num - 2;
                 num2 = 1;
                 charaMult = charaMult - 4;
              }
            if(!check)
            {
                         for(int i = num2; i > 0; i--)
                        {
                
                          if (i == 1)
                        {
                             for(int g = 0; g<= charaMult; g++)
                        {

                         Console.Write(chara);
                         }
                    
                         }
                         else
                         {
                           Console.Write(" ");
                         }
                         
                         }
            Console.WriteLine("");
            num2 --;
            charaMult = charaMult + 2;
            }
            else
            {
                        for(int i = 0; i <= num2; i++)
                        {
                
                          if (i == num2)
                        {
                             for(int g = 0; g<= charaMult; g++)
                        {

                         Console.Write(chara);
                         }
                    
                         }
                         else
                         {
                           Console.Write(" ");
                         }

                     
                
                         }

            Console.WriteLine("");
            num2++;
            charaMult = charaMult -2;
            }
            
          }

        }


    }
}
