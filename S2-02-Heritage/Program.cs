using System;

namespace S2_02_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            
             Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Bienvenue dans le programme S2-03-DevoirMaisonHeritage",150));
            
            
             Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Voulez vous commencez?",150));
             string ennoncer = HelpForme.RetourDuneStringDansUnTableauDeDeuxCase("1 - Oui", "2 - Quitter",150);
             Console.WriteLine(ennoncer);
             byte choix = Help.MaxMinByte(1,2);
             // choix de quitter ou de lancer le programme
             switch(choix)
             {
                 case 1:
                 CommencerLeProgramme();
                 break;
                 case 2:
                 Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Merci d'avoir lancer le programme",150));
                 break;
             }
        
        }


        static void CommencerLeProgramme ()
        {
            
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Bienvenue dans votre nouveau convoi !!!",150));
            Convoi convoi = new Convoi();

            ChoixPrincipaux(convoi);
        }

        static void ChoixPrincipaux (Convoi convoi)
        {

            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Que voulez vous faire ?",150));
            string ennoncer = HelpForme.RetourDuneStringDansUnTableauSelonLeTableauDeStrings(new string[4]{"1 - Ajouter un vehicule dans le convoi", "2 - Supprimer un vehicule dans le convoi", "3 - Information sur le convoi", "4 - Terminer le programme" },150);
            Console.WriteLine(ennoncer);
            int choix = Help.MaxMinByte(1,4);
            switch(choix)
            {
                case 1:
                AjouterVehicule (convoi);
                break;
                case 2:
                SupprimerVehicule(convoi);
                break;
                case 3:
                infoConvoie(convoi);
                break;
                case 4:
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Merci d'avoir lancer le programme",150));
                break;
            }

        }

        static void infoConvoie (Convoi convoi)
        {
            Console.WriteLine(convoi.ToString());
            ChoixPrincipaux(convoi);
        }

        static void AjouterVehicule (Convoi convoi)
        {
            string ennoncer = HelpForme.RetourDuneStringDansUnTableauSelonLeTableauDeStrings(new string[3]{"1 - Ajouter un Petit Bus dans le convoi", "2 - Ajouter un Camion Baché dans le convoi", "3 - Ajouter un Camion Citerne dans le convoi" },150);
            Console.WriteLine(ennoncer);
            int choix = Help.MaxMinByte(1,3);
            switch(choix)
            {
                case 1:
                AjouterPetitBus(convoi);
                break;
                case 2:
                AjouterCamionBache(convoi);
                break;
                case 3:
                AjouterCamionCiterne(convoi);
                break;
                
            }
        }

        static void AjouterPetitBus (Convoi convoi)
        {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Entrer l'imatricule du Petit Bus de 4 chiffre",150));
            int demende = Help.MaxMinInt(1000,10000);
            
            
            
            convoi.AjouterVehicule(new PetitBus(demende));
            ChoixPrincipaux(convoi);
        }

        static void AjouterCamionCiterne (Convoi convoi)
        {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Entrer l'imatricule du Camion Citerne de 4 chiffre",150));
            int demende = Help.MaxMinInt(1000,10000);
            CamionCiterne camion = new CamionCiterne(demende);
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Combien de charge voulez vous ajoutez au Camion Citerne ? ca charge max est de :"+ camion.ChargeMax,150));
            int demende2 = Help.MaxMinInt(0,camion.ChargeMax);
            
            camion.SetCharge(demende2);
            
            
            
            convoi.AjouterVehicule(camion);
            ChoixPrincipaux(convoi);
        }

        static void AjouterCamionBache (Convoi convoi)
        {
             Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Entrer l'imatricule du Camion Baché de 4 chiffre",150));
            int demende = Help.MaxMinInt(1000,10000);
            CamionBache camion = new CamionBache(demende);
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Combien de charge voulez vous ajoutez au Camion Baché ? ca charge max est de :"+ camion.ChargeMax,150));
            int demende2 = Help.MaxMinInt(0,camion.ChargeMax);
            camion.SetCharge(demende2);
            
            
            
            convoi.AjouterVehicule(camion);
            ChoixPrincipaux(convoi);
        }

        static void SupprimerVehicule (Convoi convoi)
        {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Entrer l'imatricule du vehicule que vous voulez supprimer",150));
            int demende = Help.MaxMinInt(1000,10000);

            bool supp = convoi.RetirerVehiculeCelonImatricule(demende);

            if(!supp)
            {
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Ce vehicule n'existe pas",150));
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Recommencer ?",150));
            string ennoncer = HelpForme.RetourDuneStringDansUnTableauSelonLeTableauDeStrings(new string[2]{"1 - Oui", "2 - Non" },150);
            Console.WriteLine(ennoncer);
            int choix = Help.MaxMinByte(1,2);
            switch(choix)
            {
                case 1:
               SupprimerVehicule(convoi);
                break;
                case 2:
                ChoixPrincipaux(convoi);
                 
                break;
                
            }
            }
            else
            {
            ChoixPrincipaux(convoi);
            }

            

            
        }


    }
}
