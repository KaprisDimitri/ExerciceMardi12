using System;
using System.Collections.Generic;
using System.Linq;
using PenduG;

namespace DevoirMaisonTableau
{
    class Program
    {
       static Dictionary<char, char> accentDic = new Dictionary<char, char>();
        static void Main(string[] args)
        {
     
            Help. DoListAccent();
            //Lancement du jeu Pendu;
            Pendu.PenduMain();

            // Partie Pour le Palyndrome
            bool palyndrome;
             Help.EcrireUnMessage("Ecrivez un mot pour savoir si c'est un palyndrome", 1);
            palyndrome = Palyndrome(Help.ReadLineAStringRemoveAllCharaSpe());
            if(palyndrome)
            {
                 Help.EcrireUnMessage("C'est un palyndrome", 1);
            }
            else
            { 
                Help.EcrireUnMessage("Ce n'est pas un palyndrome", 1);
            }


            //Création de char pour la fonction TriChar
            char[] aTrier = new char[6];
            aTrier[0] = 'b';
            aTrier[1] = 'B';
            aTrier[2] = 'A';
            aTrier[3] = 'Q';
            aTrier[4] = 'A';
            aTrier[5] = 'A';
             
             Console.WriteLine("\n========With Out Store=======");
             for(int i = 0; i<aTrier.Length; i++)
             {
                 Console.Write(aTrier[i]);
             }

             Console.WriteLine("\n========With Store=======");
             aTrier = TriChar ( aTrier);
             for(int i = 0; i<aTrier.Length; i++)
             {
                 Console.Write(aTrier[i]);
             }
            
            // Creation des string pour le trie Alphabétique (non Fonctionnel)
           /* string[] aTrierString = new string[6];
              aTrierString[0] = "Afqq";
              aTrierString[1] = "Acqq";
              aTrierString[2] = "Aeqq";
              aTrierString[3] = "Adqq";
              aTrierString[4] = "Abqq";
              aTrierString[5] = "Aaqq";
              for(int i = 0; i<aTrierString.Length; i++)
             {
                 Console.WriteLine(aTrierString[i]);
             }
                 aTrierString = TrieOrdreAlphabétiqueString(aTrierString);
                 for(int i = 0; i<aTrierString.Length; i++)
             {
                 Console.WriteLine(aTrierString[i]);
             }*/

              

        }
        // Fonction qui sort un Tableau de char tiré par ordre alphabétique
        static char[] TriChar (char[] aTrier)
        {
            string menage = Help.MettreDesCharEnString(aTrier);
            menage = Help.ChangementCharactereSpeciauxEtMaj(menage);
            menage = Help.EnleverCaraSpéciaux(menage);
            aTrier = Help.StringToCharArray(menage);
            aTrier = Help.TrieOrdreAlphabétiqueChar(aTrier);
            return aTrier;
            
        }

        //FOnction qui permet de toruvé si un mot est un palyndrome
        static bool Palyndrome (string mot)
        {
            mot = Help.ChangementCharactereSpeciauxEtMaj (mot);
            mot = Help.EnleverCaraSpéciaux(mot);
            char[] tableauDuMot = Help.StringToCharArray(mot);
            int moitierDuMot = tableauDuMot.Length/2;
            for(int i = 0; i < moitierDuMot; i ++)
            {
               
                  if(Help.ValueOfAKeyASCIITable (tableauDuMot[i]) != Help.ValueOfAKeyASCIITable (tableauDuMot[tableauDuMot.Length-1-i]))
                  {
                       
                      return false;
                  
                  }
            }
           
            return true;
        }
        // Fonction qui trie des string alphabétiquement (Ne Fonctionne pas)
           public static string[] TrieOrdreAlphabétiqueString (string[] messages)
        {
            messages = Help.MenageDunTableauDeString(messages);
            string mess;
            string stock;
            char[] mesArr;
            char[] mesArrCompare;
            string[] messages2 = new string[messages.Length];
            
             for(int i = 0; i<messages.Length; i++)
             {
                  Console.WriteLine("============");
                mess = messages[i];
                mesArr = Help.StringToCharArray(mess);
                int[] nombre = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(mesArr);
                 for(int f = i; f<messages.Length; f++)
                 {
                     Console.WriteLine("-------------");
                     stock = messages[f];
                    
                     mesArrCompare = Help.StringToCharArray(messages[f]);
                     int[] nombre2 = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(mesArrCompare);
                     Console.WriteLine(mess + " mess");
                     Console.WriteLine(stock + " stock");
                     Console.WriteLine(messages[i] + " For stock");
                     Console.WriteLine(messages[f] + " For mess");
                   for(int q = 0; q < nombre2.Length; q++)
                    {
                        if(nombre2[q] < nombre[q])
                      {
                          Console.WriteLine("aaaaaaaaaaaa");
                        messages[i] = messages[f];

                        messages[f] = mess;
                       
                       
                    
                         Console.WriteLine(messages[i]+ i +" "+ nombre2[q]+q);
                         Console.WriteLine(messages[f]+ f +" "+ nombre[q]+q);
                         
                        
                         
                        q = nombre2.Length;
                      }
                      else if ( nombre2[q] > nombre[q])
                      {
                          q = nombre2.Length;
                      }
                      
                      
                    }


                   /*  if(nombre2[0] < nombre[0])
                      {
                          //  Console.WriteLine("aaaaaaaaaaaa");
                        messages[i] = stock;
                      messages[f] = mess;
                      messages2[i] = stock;
                         Console.WriteLine(messages[i] + " Put In Message i"+ i);
                          Console.WriteLine(messages[f] + " Put In Message f"+ f);
                    //    Console.WriteLine(messages[i]+ i +" "+ nombre2[0]);
                    //     Console.WriteLine(messages[f]+ f +" "+ nombre[0]);
                      }
                      else if (nombre2[0] ==  nombre[0])
                      {
                          
                          
                          if(nombre2[1] < nombre[1] )
                          {
                              messages[i] = stock;
                          messages[f] = mess;
                          messages2[i] = stock;
                                Console.WriteLine(messages[i] + " Put In Message i"+ i);
                          Console.WriteLine(messages[f] + " Put In Message f" + f);
                            //  Console.WriteLine(messages[i]+ i +" "+ nombre2[1]);
                         //Console.WriteLine(messages[f]+ f +" "+ nombre[1]);
                          }
                          else if (nombre2[1] ==  nombre[1])
                          {
                              //Console.WriteLine("yo");
                               if(nombre2[2] < nombre[2])
                             {
                              messages[i] = stock;
                             messages[f] = mess;
                             messages2[i] = stock;
                                Console.WriteLine(messages[i] + " Put In Message i" + i);
                          Console.WriteLine(messages[f] + " Put In Message f" + f);
                              
                            //  Console.WriteLine(messages[i]+ i +" "+ nombre2[2]);
                         //Console.WriteLine(messages[f]+ f +" "+ nombre[2]);
                            }
                          }

                      }*/
                      
                      
                   
                 }
                 
             }

           return messages;

        }


      
    }
}
