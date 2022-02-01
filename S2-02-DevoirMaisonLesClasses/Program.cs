using System;

namespace S2_02_DevoirMaisonLesClasses
{
    class Program
    {
        //Entrer Programme
        static void Main(string[] args)
        {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Bienvenue dans le programme S2-02-DevoirMaisonLesClasses",150));
            
            
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

        //Initialisation du programme
        static void CommencerLeProgramme ()
        {
            
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Bienvenue dans votre nouveau parking !!!",150));
            Parking parking = new Parking(10,5f);
            Client client = new Client();

            ChoixPrincipaux(parking, client);
        }

        //Fonction pour choisir notre action
        static void ChoixPrincipaux (Parking parking, Client client)
        {

            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Que voulez vous faire ?",150));
            string ennoncer = HelpForme.RetourDuneStringDansUnTableauSelonLeTableauDeStrings(new string[4]{"1 - Ajouter un voiture dans le parking", "2 - Supprimer une voiture dans le parking", "3 - Information sur le parking", "4 - Terminer la journée" },150);
            Console.WriteLine(ennoncer);
            int choix = Help.MaxMinByte(1,4);
            switch(choix)
            {
                case 1:
                AjoutVoiture(parking, client);
                break;
                case 2:
                SuppresionVoiture(parking,client);
                break;
                case 3:
                AfficherInfoParking(parking,client);
                break;
                case 4:
                FinDeJourner(parking,client);
                break;
            }

        }
        
        //Fonction qui appel le constructeur de Car et donne le choix du nom
        static Car CreationDeVoiture ()
        {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Entrer le nom du client",150));
            string demende = Console.ReadLine();
            
            
            string nom = demende;
            return new Car(nom);

        }
        
        //FOnction d'action dajout d une voiture dans le parking
        static void AjoutVoiture (Parking parking, Client client)
        {
            Car voiture = CreationDeVoiture();
            int place =parking.AjouterVoitureDansParking(voiture);
            if(place != -1)
            {
                Ticket ticket = client.CreationDUnNouveauClient(voiture);
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque(ticket.InfosTicket(), 150));
                ticket.Place = place;
                ticket.PlaceParking = place;
            }
            else
            {
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("il n'y a plus de place dans le parking",150));
            }

            ChoixPrincipaux(parking,client);
        }
        
        //Fonction d'action de suppresion d'une voiture dans le parking
        static void SuppresionVoiture (Parking parking, Client client)
        {
            
            
            if(client.ListeTicket.Length !=0)
            {
               
                Ticket ticket = client.TicketAlleatoire();
                
            if(parking.SupprimerVoitureDansParkingParInt(ticket.PlaceParking))
            {
                float argentGagner = parking.EmpocherLArgent(ticket.HeureDentrer);
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("le client "+ ticket.Voiture.NomDuProprietaire + " est partie du parking.",150));
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("il vous dois " + argentGagner + " euros.",150));
                client.SupressionDeTicket(ticket);
            }
            else
            {
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Ce client n'est pas dans le parking",150));
            }
            }
            else
            {
                Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("il n'y a pas de client dans ce parking",150));
            }

            ChoixPrincipaux(parking,client);
        }

        //Fonction qui appel al fonction des info du parking dans l objet parking
        static void AfficherInfoParking (Parking parking, Client client)
        {
            Console.WriteLine( parking.InfoParking());
            ChoixPrincipaux(parking,client);
        }
         
         //Fonction qui permet de remporter l'argent de la journée
        static void FinDeJourner (Parking parking, Client client)
        {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("La journé est finie.",150));
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Vous avez gagnez "+ parking.ArgentGagné +" aujourd'hui", 150));
            RecommencerOuNon(parking,client);
        }
         
         //Fonction qui nous donne le choix de continuer, de recommencer, de quitter
        static void RecommencerOuNon (Parking parking, Client client)
        {
            Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Voulez vous recommencez ?",150));
            Console.WriteLine(HelpForme.RetourDuneStringDansUnTableauSelonLeTableauDeStrings(new string[3]{"1 - Continuer", "2 - Recommencer", "3 - Quitter"},150));
            byte choix = Help.MaxMinByte(1,3);
            switch(choix)
            {
                case 1:
                ChoixPrincipaux(parking,client);
                break;
                case 2:
                CommencerLeProgramme();
                break;
                case 3:
                 Console.WriteLine(HelpForme.RetourDuneStringDansUnBloque("Merci d'avoir lancer le programme",150));
                break;
            }
            choix = 0;
        }



    
    }
}
