using System;


namespace S2_01_DevoirMaisonLesPointeur
{
    unsafe class Program
    {
        //Enter du programme
        static void Main(string[] args)
        {
            // decalage pour l'affichage Console
           int decalage = 100;
           Console.WriteLine( HelpForme.RetourDuneStringDansUnBloque("Bienvenue dans le programme du devoir maison sur les pointeurs",decalage));
           InitialisationProgramme(decalage);

        }

        //Fonction initialisation Programme
        static void InitialisationProgramme(int decalage)
        {
            //Choix de l'exercice
           Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Quelle exercices voulais vous lancer ?",decalage));
           Console.WriteLine( HelpForme.RetourDuneStringDansUnTableauDeDeuxCase("1-Exercice 1", "2-Exercice 2",decalage));
           //demande d'entrer un chiffre
           int choix = Help.MaxMinByte(1,2);
           if(choix == 1)
           {
               ExerciceNumeroUn(decalage);
           }
           else if(choix == 2)
           {
               ExerciceNumeroDeux (decalage);
           }
           //Choix de recommencer la fonction
           Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Voulez vous faire un autre exercice ?",decalage));
           Console.WriteLine( HelpForme.RetourDuneStringDansUnTableauDeDeuxCase("1- oui", "2- non",decalage));
            //demande d'entrer un chiffre
           choix = Help.MaxMinByte(1,2);
           if(choix == 1)
           {
               InitialisationProgramme(decalage);
           }
        }
        
        //Fonction pour lancer l'exercice 2
        static void ExerciceNumeroDeux (int decalage)
        {
            int choix = 0;
            //Creaton du boss
            BossStruct.Boss boss = new BossStruct.Boss(100, 0.5f);
            
            //Creation des joueurs
            PlayerStruct.Player player1 = new PlayerStruct.Player("Henri", 10, &boss);
            PlayerStruct.Player player2 = new PlayerStruct.Player("Jean", 5, &boss);

            //Infos du boss
            boss.InfosSurLeBoss();

            //Attack des joueurs
            string[] choixEcrit = new string[4] {"1-"+player1.nom, "2-"+player2.nom, "3-Partir", "4-Infos Boss"};
            do
            {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Avec qui voulez vous attaquer?",decalage));
            Console.WriteLine( HelpForme.RetourDuneStringDansUnTableauSelonLeTableauDeStrings(choixEcrit,decalage));
            choix = Help.MaxMinByte(1,(byte)choixEcrit.Length);
            if(choix == 1)
            {
               player1.Attack();
            }
            else if( choix == 2)
            {
                player2.Attack();
            }
            else if(choix == 4)
            {
                boss.InfosSurLeBoss();
            }

            }while(choix !=3);

             //Infos du boss
            boss.InfosSurLeBoss();
           
           //Choix de recommencer la fonction
           Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Voulez vous recommencez?",decalage));
           Console.WriteLine( HelpForme.RetourDuneStringDansUnTableauDeDeuxCase("1- oui", "2- non",decalage));
            //demande d'entrer un chiffre
           choix = Help.MaxMinByte(1,2);
           if(choix == 1)
           {
               ExerciceNumeroDeux(decalage);
           }
        }
        

        //Fonction pour lancer l'exercice 1
        static void ExerciceNumeroUn (int decalage)
        {
            //Creation des variable de type char et char* (pointeur)
              char caractere1 = 'O';
              char caractere2 = 'A'; 
              char* pointeur1 = &caractere1;
              char* pointeur2 = &caractere2;
            
            //Affichage des valeur des pointeur dans la console
            Console.WriteLine("----------Valeur des pointeurs avant passage dans la fonction ----------");
            Console.WriteLine($"Valeur {nameof(pointeur1)} : {*pointeur1}");
            Console.WriteLine($"Valeur {nameof(pointeur2)} : {*pointeur2}");
            Console.WriteLine("------------------------------------------------------------------------\n");
            
            //Appel de la fonction qui assigne la valeur du pointeur1 au pointeur2
             ChangementDeValeur( pointeur1, pointeur2);
            
            //Affichage des valeur des pointeur dans la console
            Console.WriteLine("----------Valeur des pointeurs après passage dans la fonction ----------");
            Console.WriteLine($"Valeur {nameof(pointeur1)} : {*pointeur1}");
            Console.WriteLine($"Valeur {nameof(pointeur2)} : {*pointeur2}");
            Console.WriteLine("------------------------------------------------------------------------\n");
           
           //Choix de recommencer la fonction
           Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Voulez vous recommencez?",decalage));
           Console.WriteLine( HelpForme.RetourDuneStringDansUnTableauDeDeuxCase("1- oui", "2- non",decalage));
            //demande d'entrer un chiffre
           int choix = Help.MaxMinByte(1,2);
           if(choix == 1)
           {
               ExerciceNumeroUn(decalage);
           }
        }

        //Fonction qui assigne la valeur du point1 au point2
        static void ChangementDeValeur (char* point1, char*point2)
        {
            //assigne la valeur du point1 au point2;
            *point2 = *point1;
        }
    }
}
