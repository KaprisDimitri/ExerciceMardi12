using System;
public class Parking
{
     //Proprieter de la class Parking
     Car[] _voitureDansLeParking;
     
     float _prixHeure;
     float _argentGagné;

     //Constructeur de la class Parking
     public Parking (int nombreDePlaceMax, float prixHeure)
     {
         if(nombreDePlaceMax < 1)
         {
             _voitureDansLeParking = new Car[1];
         }
         else
         {
             _voitureDansLeParking = new Car[nombreDePlaceMax];
         }

         if(prixHeure>0)
         {
         _prixHeure = prixHeure;
         }
         else
         {
             _prixHeure = 1f;
         }

         _argentGagné = 0;
     }

     // Accesor permet de recupérer la valeur des proprieter de la class Parking

     public Car[] VoitureDansLeParking
     {
         get
         {
             return _voitureDansLeParking;
         }
     }

     public float ArgentGagné
     {
         get
         {
             return _argentGagné;
         }
     }

     public float PrixHeure
     {
          get
          {
              return _prixHeure;
          }
     }
     

     // Fonction de la CLass Parking

     //Fonction qui permet d ajouter une voiture dans parking
     public int AjouterVoitureDansParking (Car voiture)
     {
          int place = -1;
          for(int i = 0; i<_voitureDansLeParking.Length; i++)
          {
              if(_voitureDansLeParking[i]== null)
              {
                 place = i;
                 break;
              }
          }
          if(place != -1)
          {
               _voitureDansLeParking[place] = voiture;
               return place;
          }
          else
          {
              
              return -1;
          }
     }

     //Fonction qui permet de supprimer la voiture du parking par ca place
     public bool SupprimerVoitureDansParkingParInt (int place)
     {
         if(place >= 0 && place < _voitureDansLeParking.Length )// _voitureDansLeParking[place] != null)
         {
           _voitureDansLeParking[place] = null;
           return true;
         }
         else
         {
             return false;
         }
     }
 

     //FOnction qui permet de supprimer une voiture du parking par le nom du client
     public bool SupprimerVoitureDansParkingParNom (string nom)
     {
         for(int i = 0; i<_voitureDansLeParking.Length; i++)
         {
             if(_voitureDansLeParking[i].NomDuProprietaire == nom)
             {
                 _voitureDansLeParking[i] = null;
                 return true;
             }
         }
         return false;
         
     }
    
    //Fonction qui calcul l'argent gagné par rapport au prix par heure
     public float EmpocherLArgent (DateTime heureArriver)
     {
       /*  DateTime heureSortie = DateTime.Now;

         int ajout = 0;
         if(heureSortie.Second < heureArriver.Second)
         {

         }*/

         _argentGagné += _prixHeure;
         return _prixHeure;
     }
 

     // fonction qui renvoie une string comptenant les infos du parking
     public string InfoParking ()
     {
         string etatParking = "";
        
         for(int i = 0; i< _voitureDansLeParking.Length; i++)
         {
             etatParking+= "Place numéro "+ i + " :\n";
            if(_voitureDansLeParking[i] == null)
            {
                etatParking +=" Place Libre \n";
            }
            else
            {
                etatParking += "Nom:" + _voitureDansLeParking[i].NomDuProprietaire+"\n";
            }
         }
         return etatParking;
     }
}