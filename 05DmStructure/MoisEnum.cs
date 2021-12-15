using System;
class MoisEnum
{
    //Enum pour les mois , saison , coleur;
    public enum Couleur
        {
            Rouge,
            Jaune,
            Blanc,
            Vert
            
        }

        public enum Mois
        {
            Janvier = 1,
            Fevrier,
            Mars,
            Avril,
            Mai,
            Juin,
            Juillet,
            Aout,
            Septembre,
            Octobre,
            Novembre,
            Decembre
        }

        public enum Saison
        {
            Hiver,
            Printemps,
            Ete,
            Automne
        }

// Fonction d entré pour connaitre le mois, sa saison sa couleur.
          public static void FonctionDeDemaragePourLesMois()
        {
             byte numPourQuitter = 0;
            do
            {
            byte numMois = 0;
            do
            {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Entrée un mois pour connaitre la saison et la couleur associé!!!"));
            string key = Console.ReadLine();
            string moisArray;
            if(Help.IsAByteOrNot(key))
            {
                
             numMois = Help.MaxMinByte(key, 1, 12);
             
            }
            else if (!Help.IsAByteOrNot(key))
            {
                
                for(int i = 1; i< 13; i++)
                {
                    moisArray = Enum.GetName(typeof(Mois), i);
                     if(Help.CheckThePropoWithWord(Help.StringToCharArray(key), Help.StringToCharArray(moisArray)))
                     {
                         
                         numMois = (byte)i;
                     }

                    
                }
               
            }
            }while(numMois == 250);
            
            string info = RetourDunMessagePourLesInfosDuMois(numMois);
            Console.WriteLine(info);
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Voulez vous recommencé ?"));
            Console.WriteLine(HelpForme.RetourDuneStringDansUnTableauDeDeuxCase("1 - Oui", "2 - Non"));
           
            numPourQuitter = Help.MaxMinByte(1,2);
        }while (numPourQuitter == 1);
        {
             
        }


        }

       
//String pour toute les info
        public static string RetourDunMessagePourLesInfosDuMois (byte num)
        {
                Mois moisActu = CheckLeMois(num);
                Saison saisonActu = CheckLaSaison(moisActu);
                Couleur coulActu = CheckLaCouleur(saisonActu);
                return "Le mois demandé est : " + moisActu + ".\nIl est a la saison : "+ saisonActu +".\nAssocié a la couleur : "+ coulActu+".";
        }

//Trouvé le mois cherché
        public static Mois CheckLeMois (byte numDeMois)
        {
            return (Mois)numDeMois;
        }
        //Trouvé le saison cherché
         public static Saison CheckLaSaison (Mois numMois)
        {
            Saison actu = Saison.Ete;
            if((int)numMois >0 && (int)numMois<4 || (int)numMois >11 && (int)numMois<13)
            {
                actu = (Saison)0;
            }
            else if((int)numMois >3 && (int)numMois<7)
            {
                actu = (Saison)1;
            }
             else if((int)numMois >6 && (int)numMois<10)
            {
                actu = (Saison)2;
            }
             else if((int)numMois >9 && (int)numMois<12)
            {
                actu = (Saison)3;
            }
            return actu;
        }
//Trouvé le Couleur cherché
        public static Couleur CheckLaCouleur (Saison numSaison)
        {
            return (Couleur)numSaison;
        }
    }
