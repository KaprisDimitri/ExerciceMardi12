using System;
using System.Collections.Generic;
using System.Linq;
class Help
{
    static Dictionary<char, char> accentDic = new Dictionary<char, char>();

    //Creation du tableau des accent
    public static void DoListAccent()
    {
        //Accent a rajouté dans le dictionnaire
       // {'Æ','Ì','Í','Ò','Ó','Ô','Õ','Ö','×','Ù','Ú','Û','Ü','Ý','Þ','ß','à','á','â','ã','ä','å','æ','ç','è','é','ê','ë','ì','í','î','ï','ð','ñ','ò','ó','ô','õ','ö','ù','ú','û','ü','ý','ÿ'};
       // static char[] charSource = {'A','A','A','A','A','A','A','C','E','E','E','E','I','I','I','I','D','N','O','O','O','O','O','X','U','U','U','U','Y','P','B','A','A','A','A','A','A','A','C','E','E','E','E','I','I','I','I','O','N','O','O','O','O','O','U','U','U','U','Y','Y'};
            accentDic.Add('é','e');
            accentDic.Add('è','e');
            accentDic.Add('ê','e');
            accentDic.Add('ë','e');
            accentDic.Add('à','a');
            accentDic.Add('á','a');
            accentDic.Add('ã','a');
            accentDic.Add('å','a');
            accentDic.Add('â','a');
            accentDic.Add('ä','a');
            accentDic.Add('ç','c');
            accentDic.Add('î','i');
            accentDic.Add('ï','i');
            accentDic.Add('ð','d');
            accentDic.Add('ñ','n');

    

    }
//Ecriture du message pour le max et minimum
    static void MessageMaxMin (double min, double max)
    {
        Console.WriteLine("la valeur que vous avez saisie n'est pas entre "+ min +" et "+ max +".");
    }
// Fonction pour verifié si c'est un byte avec un max et min
    public static byte MaxMinByte(byte min, byte max)
    {
        byte value = 0;
        bool isvalid = true;
        do
        {
            value = GoodInputByte();

            isvalid = value < min || value > max;
            if(isvalid)
            {
                MessageMaxMin (min, max);
            }

        } while (isvalid);
        return value;
    }
    // Fonction pour verifié si c'est un byte
    public static byte GoodInputByte ()
     {
         if(byte.TryParse(Console.ReadLine(), out byte num))
         {
                 return num;
         }
         else
         {
             Console.WriteLine("Erreur de saisie");
             GoodInputByte ();
         }

         return 0;

     }
    public static short MaxMinShort(short min, short max)
    {
        short value = 0;
        bool isvalid = true;
        do
        {
            value = GoodInputShort();

            isvalid = value < min || value > max;
            if(isvalid)
            {
                MessageMaxMin (min, max);
            }

        } while (isvalid);
        return value;
    }
    public static short GoodInputShort ()
     {
         if(short.TryParse(Console.ReadLine(), out short num))
         {
                 return num;
         }
         else
         {
             Console.WriteLine("Erreur de saisie");
             GoodInputShort ();
         }

         return 0;

     }
    public static int MaxMinInt(int min, int max)
    {
        int value = 0;
        bool isvalid = true;
        do
        {
            value = GoodInputInt();

            isvalid = value < min || value > max;
            if(isvalid)
            {
                MessageMaxMin (min, max);
            }

        } while (isvalid);
        return value;
    }
    public static int GoodInputInt ()
     {
         int num;
         if(int.TryParse(Console.ReadLine(), out num))
         {
                 
                    return num;
                 
         }
         else
         {
             Console.WriteLine("Erreur de saisie");
             GoodInputInt ();
         }

         return 0;

     }
    public static long MaxMinLong(long min, long max)
    {
        long value = 0;
        bool isvalid = true;
        do
        {
            value = GoodInputLong();

            isvalid = value < min || value > max;
            if(isvalid)
            {
                MessageMaxMin (min, max);
            }

        } while (isvalid);
        return value;
    }
    public static long GoodInputLong ()
     {
         if(long.TryParse(Console.ReadLine(), out long num))
         {
                 return num;
         }
         else
         {
             Console.WriteLine("Erreur de saisie");
             GoodInputLong ();
         }

         return 0;

     }
    public static float MaxMinFloat(float min, float max)
    {
        float value = 0;
        bool isvalid = true;
        do
        {
            value = GoodInputFloat();

            isvalid = value < min || value > max;
            if(isvalid)
            {
                MessageMaxMin (min, max);
            }
        } while (isvalid);
        return value;
    }
    public static float GoodInputFloat ()
     {
         if(float.TryParse(Console.ReadLine(), out float num))
         {
                 return num;
         }
         else
         {
             Console.WriteLine("Erreur de saisie");
             GoodInputFloat ();
         }

         return 0;

     }
    public static double MaxMinDouble(double min, double max)
    {
        double value = 0;
        bool isvalid = true;
        do
        {
            value = GoodInputDouble();

            isvalid = value < min || value > max;
            if(isvalid)
            {
                MessageMaxMin (min, max);
            }

        } while (isvalid);
        return value;
    }
    public static double GoodInputDouble ()
     {
         if(double.TryParse(Console.ReadLine(), out double num))
         {
                 return num;
         }
         else
         {
             Console.WriteLine("Erreur de saisie");
             GoodInputDouble ();
         }

         return 0;

     }
    //Fonction pour trouvé la valeur du char sur la table d'ascii
    public static byte ValueOfAKeyASCIITable (char key)
    {
        if((key != '\0'))
        {
        byte keyValue = Convert.ToByte(key);
        return keyValue;
        }
        return 0;
    }
   //Fonction qui permet de changé une valeur en char de la table d'ascii
    public static char CharOfAKeyASCIITable (int value)
    {
        if(value <= 127)
        {
        char key = Convert.ToChar(value);
        return key;
        }
        return '\0';
    }
    //Fonction pour changé une string en tableau de char
    public static char[] StringToCharArray (string message)
    {
        char[] characters;
        if(message != null || message != " ")
        {
            characters = message.ToCharArray();
            return characters;
        }
        return characters = new char[0];
    }
    //Fonction qui permet d'ecrire un message
    public static void EcrireUnMessage (string message, int modeDeMessage)
    {
        if(modeDeMessage == 1)
        {
        Console.WriteLine(message);
        }
        else
        {
            Console.Write(message);
        }
    }
    //Fonction qui permet d enlevé les majuscule dans une string
    public  static string ChangementCharactereSpeciauxEtMaj (string message)
        {
              char[] list = Help.StringToCharArray(message);
              for(int i = 0; i < list.Length;i++)
              {
                  if(Help.ValueOfAKeyASCIITable(list[i]) > 64 && Help.ValueOfAKeyASCIITable(list[i]) < 91)
                  {
                      int c = Help.ValueOfAKeyASCIITable(list[i]) + 32;
                      list[i] = Help.CharOfAKeyASCIITable(c);
                  }
                  
              }
              string motSansMajEtCharacterespeciaux = MettreDesCharEnString(list);
              return motSansMajEtCharacterespeciaux;
        }
    //Fonction qui permet de mette un tableau de char en string
    public  static string MettreDesCharEnString (char[] message)
        {
            string mess = "";
            
            for(int i = 0; i < message.Length; i++)
            {
                mess += message[i];
            }
            return mess;

        }
    //Fonction qui permet de retiré tout les charactère autre que les lettre
    public  static string EnleverCaraSpéciaux (string messages)
        {
            string mess = "";
            char[] message = StringToCharArray(messages);
            
            
            
                 
                for(int i = 0; i < message.Length; i++)
            {
                 
                if(ValueOfAKeyASCIITable(message[i]) != 0 && ValueOfAKeyASCIITable(message[i]) > 64)
                {
                    
                    if(ValueOfAKeyASCIITable(message[i]) < 91 || ValueOfAKeyASCIITable(message[i]) > 96)
                    {
                         message[i] =  AccentEgale (message[i]);
                        if(ValueOfAKeyASCIITable(message[i]) < 123)
                        {
                            
                      mess += message[i];
                    
                       }
                    }
                }
            }
            
            return mess;

        }
   //Fonction qui permet de changé les accent en lettre sans accent
    public static char AccentEgale (char accent)
        {
            for(int i =0; i< accentDic.Count; i++)
            {
            if(ValueOfAKeyASCIITable(accentDic.ElementAt(i).Key) == ValueOfAKeyASCIITable(accent))
            {
               
                accent = accentDic.ElementAt(i).Value;
                return accent;
            }
            }
            
             return accent;


            
        }
    //Fonction qui permet de verifié si c est bien un char en Input
    public static char GoodInputChar ()
     {
         if(char.TryParse(Console.ReadLine(), out char num))
         {
                 return num;
         }
         else
         {
             Console.WriteLine("Erreur de saisie");
             GoodInputChar ();
         }

         return '\0';

     }
   //FOnction qui permet d'écrire une string et d enlever tout les majuscule et caratère spéciaux
     public static string ReadLineAStringRemoveAllCharaSpe ()
     {
         bool check = false;
         string mot = "";
         while(!check)
         {
         mot = Console.ReadLine();
         mot = EnleverCaraSpéciaux(mot);
         mot = ChangementCharactereSpeciauxEtMaj(mot);
            if(mot =="")
            {
             
             EcrireUnMessage("Une erreur de saisie est survenue", 1);
             
            }
            else
             {
             check = true;
            }
         }
         
         return mot;
     }
     //Fonction qui permet de trié des char alphabetiquement
    public static char[] TrieOrdreAlphabétiqueChar (char[] messages)
        {
            int[] nombre = new int[messages.Length];
            for(int i = 0; i<messages.Length; i++)
            {
                nombre[i] = Help.ValueOfAKeyASCIITable(messages[i]);
            }
            int stock;
            int min;


             for(int i = 0; i<nombre.Length; i++)
             {
             min = nombre[i];
             for(int f = i; f<nombre.Length; f++)
              {

                if(nombre[f] <min)
                {

                min = nombre[f];
                stock = nombre[i];
                nombre[f] = stock;
                nombre[i] = min;
                }
              }
            }
            for(int i = 0; i<messages.Length; i++)
            {
                messages[i] = Help.CharOfAKeyASCIITable(nombre[i]);
            }

            return messages;

        }

        //Fonction qui permet de changé une array de char en valeur de la table s'ascii
    public static int[] ChangementDUneArrayDeCharEnArrayDeValueAscii (char[] changement)
        {
            int[] nombre = new int[changement.Length];
            for(int i = 0; i<changement.Length; i++)
                 {
                     nombre[i] = Help.ValueOfAKeyASCIITable(changement[i]);
                 }

            return nombre;
        }
// Fonction aui permet d enlever tout les maj et caracthère spéciaux dans un tableau de string
    public static string[] MenageDunTableauDeString (string[] changement)
        {
             for(int i = 0; i <changement.Length; i++)
            {
                changement[i] = Help.ChangementCharactereSpeciauxEtMaj(changement[i]);
                changement[i] = Help.EnleverCaraSpéciaux(changement[i]);
            }

            return changement;

        }

    public static int AvoirLeNombreDeCharDansUneString (string message)
    {
        char[] mess = StringToCharArray(message);
        int nombre = mess.Length;
        return nombre;
    }

    public  static string MettreDesStringEnString (string[] message)
        {
            string mess = "";
            
            for(int i = 0; i < message.Length; i++)
            {
                mess += message[i];
            }
            return mess;

        }

           //Fonction qui check si il y a des lettre trouvé ou non
        public static bool CheckThePropoWithWord(char[] propos, char[] mot)
        {
           
           
                int[] proposValue = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(propos);
                int[] motValue = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(mot);
                for(int i = 0; i < mot.Length;i ++)
                {
                    if(proposValue[i] !=motValue[i])
                    {
                        return false;
                    }
                }
                return true;
           
           
        }

//Fonction qui retourne un bool si le nombre est un byte ou non
         public static bool IsAByteOrNot (string key)
        {
            if(byte.TryParse(key, out byte result))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
}