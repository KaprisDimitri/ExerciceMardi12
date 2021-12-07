using System;


namespace PenduG
{
    class Pendu
    {
//Fonction qui créé les tabelau des mot du jeu
        public static string[] TableauDeMotPourLePendu (int modeDeDiff)
        {
            string[] mots1 = new string[2];
            mots1[0] = "cout";
            mots1[1] = "monter";
            if(modeDeDiff == 1)
            {
            return mots1;
            }
             else if(modeDeDiff == 2)
            {
            string[] mots2 = new string[2];
             mots2[0] = "tabulation";
            mots2[1] = "matraquer";
             return mots2;
            }
            else if(modeDeDiff == 3)
            {
            string[] mots3 = new string[2];
             mots3[0] = "marchandage";
            mots3[1] = "raterir";
             return mots3;
            }
            return mots1;
        }
//Fonction qui prend au hasard un mot dans un tableau de string
        public static string ChoixDuneStringDansUnTableau (string[] list)
        {
            Random randInit = new Random();
            int rand = randInit.Next(0, list.Length);
            return list[rand];
            
        }
// Fonction qui affiche a l utilisateur le mot trouvé
         public static string StringDuMotAvecCeQuiEstTrouvé (char[] mots)
        {
            string affMot = "";
            for(int i = 0; i < mots.Length; i ++)
            {
                if(mots[i] == '\0')
                {
                    affMot += "*";
                }
                else
                {
                    affMot += mots[i];
                }
            }
            return affMot;
            
        }
//Fonction qui etablie la vie du joueur selon le niveau de difficulté
         public static byte VieCelonLaDiff (int diff)
        {
           byte vie;
           if(diff == 1)
           {
               vie = 20;
           }
           else if (diff == 2)
           {
                 vie = 15;
           }
           else
           {
                 vie = 12;
           }

           return vie;
            
        }
//Fonction qui check si le joeur a fait un mot en proposition ou un char
        public static bool CheckIfItsOnePropose (char[] propose)
        {
            if(propose.Length == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
//Fonction qui check si il y a des lettre trouvé ou non
        public static bool CheckThePropoWithWord(char[] propos, bool charOrString, char[] mot)
        {
            if(!charOrString)
            {
                int[] proposValue = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(propos);
                int[] motValue = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(mot);
                for(int i = 0; i < mot.Length;i ++)
                {
                    if(proposValue[0] ==motValue[i])
                    {
                        return true;
                    }
                }
            }
            else
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
            return false;
        }
//Fonction qui place les lettre trouver dans le tableau du joueur
        public static char[] CheckThePropoWithWord(char[] propos, char[] mot, char[] motTrouver, bool CharOrNot)
        {
            if(!CharOrNot)
            {
             int[] proposValue = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(propos);
                int[] motValue = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(mot);
                for(int i = 0; i < mot.Length;i ++)
                {
                    if(proposValue[0] ==motValue[i])
                    {
                        motTrouver[i] = propos[0];
                    }
                }

                return motTrouver;
            }
            else
            {
                int[] proposValue = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(propos);
                int[] motValue = Help.ChangementDUneArrayDeCharEnArrayDeValueAscii(mot);
                for(int i = 0; i < mot.Length;i ++)
                {
                    if(proposValue[i] ==motValue[i])
                    {
                        motTrouver[i] = propos[i];;
                    }
                }
                 return motTrouver;
            }
            
        }

//Fonction qui check si tout le mot a etait trouvé
        public static bool CheckSiToutTrouver (char[] motTrouver)
        {
            for(int i = 0; i<motTrouver.Length; i++)
            {
                if(motTrouver[i] == '\0')
                {
                    return false;
                }
            }
            return true;
        }


//Fonction qui gère le Pendu dans ca Globalité
        public static void PenduMain ()
        {
            bool finishWord = false;
            Help.EcrireUnMessage("Choisissez votre mode de difficulté", 1);
            Help.EcrireUnMessage("1 pour facile",1);
            Help.EcrireUnMessage("2 pour normal",1);
            Help.EcrireUnMessage("3 pour dificile",1);
            byte modeDeDifficulte = Help.MaxMinByte(1, 3);
            byte vie = VieCelonLaDiff(modeDeDifficulte);
            string[] tableauDesMots = TableauDeMotPourLePendu(modeDeDifficulte);
            string mot = ChoixDuneStringDansUnTableau(tableauDesMots);

            

            char[] motEnChar = Help.StringToCharArray(mot);
            char[] motDuJoueur = new char[motEnChar.Length];


            string motDecouvert = StringDuMotAvecCeQuiEstTrouvé(motDuJoueur);
            Help.EcrireUnMessage(motDecouvert, 1);
            

            //Boucle De jeu pour que l'utilisateur joue jusqu a ce qu il est plus de vie ou il est trouvé le mot
            while(!finishWord)
            {
            string proposition = Help.ReadLineAStringRemoveAllCharaSpe();
             
            char[] propos = Help.StringToCharArray(proposition);
            bool propositionOrNot = CheckIfItsOnePropose(propos);
            
            bool trouverUneLettre = CheckThePropoWithWord(propos, propositionOrNot, motEnChar);
            if(!trouverUneLettre)
            {
                Help.EcrireUnMessage("Vous vous etes trompé", 1);
                vie --;
                 Help.EcrireUnMessage("il vous reste " + vie + " vies", 1);
                 if(vie == 0)
                 {
                     finishWord = true;
                     Help.EcrireUnMessage("Vous Avez Perdu", 1);
                 }
            }
            else
            {
                motDuJoueur = CheckThePropoWithWord(propos, motEnChar, motDuJoueur ,propositionOrNot);
                  motDecouvert = StringDuMotAvecCeQuiEstTrouvé(motDuJoueur);
                  Help.EcrireUnMessage(motDecouvert, 1);
                   finishWord = CheckSiToutTrouver(motDuJoueur);
                   if(finishWord)
                   {
                       Help.EcrireUnMessage("Vous avez gagné", 1);
                   }
            }

           
            }

            Help.EcrireUnMessage("Voulez Vous Recommencer?", 1);
            Help.EcrireUnMessage("1 pour Oui",1);
            Help.EcrireUnMessage("2 pour Non",1);
            Reboot(Help.MaxMinByte(1,2));
            
        }

// Fonction qui premet de recommencer le Pendu
        public static void Reboot(int rebootOrNot)
       {
          if(rebootOrNot == 1)
          {
              PenduMain();
          }
       }

    }
}