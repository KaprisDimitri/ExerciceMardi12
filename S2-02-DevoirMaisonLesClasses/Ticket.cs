using System;
public class Ticket
{
    //Proprieter de la class Ticket
    Car _voiture;
    DateTime _heureDentrer;

    int _place;

    int _placeParking;
    
    
    //Constructeur de la class Ticket
    public Ticket (Car voiture)
    {
        _heureDentrer = DateTime.Now;
        _voiture = voiture;
        _place = -1;
    }

    // Accesor permet de recupérer la valeur des proprieter de la class Ticket

    public Car Voiture
    {
        get
        {
            return _voiture;
        }
    }

    public DateTime HeureDentrer
    {
        get
        {
            return _heureDentrer;
        }
    }

    public int Place
    {
        get
        {
            return _place;
        }
        set
        {
            _place = value;
        }
    }

    public int PlaceParking
    {
        get
        {
            return _placeParking;
        }
        set
        {
            _placeParking = value;
        }
    }

    // Fonction qui permet de renvoyer une string comptenant les info du ticket
    public string InfosTicket ()
    {
        return "La voiture de "+ Voiture.NomDuProprietaire +" a etait ajouter a la date : "+ HeureDentrer;
    }
    
}