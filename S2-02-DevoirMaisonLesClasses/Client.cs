using System;
public class Client
{
    
    //Proprieter de la class Client
    Ticket[] _listeTicket;



 
    //Constructeur de la class Client
    
    public Client ()
    {
        _listeTicket = new Ticket[0];
    }


    // Accesor permet de recupérer la valeur des proprieter de la class Client
    public Ticket[] ListeTicket
    {
        get
        {
            return _listeTicket;
        }
    }
    // Fonction de la CLass Client

    // Fonction qui permet de tirer un client aleatoire dans la liste des clients
    public Ticket TicketAlleatoire ()
    {
        Random random = new Random();
        return _listeTicket[random.Next(0,_listeTicket.Length-1)];
    }

    // Fonction qui permet de créé un nouveau Ticket
    public Ticket CreationDUnNouveauClient (Car voiture)
    {
        Ticket[] listeTicket = _listeTicket;
        _listeTicket = new Ticket[listeTicket.Length+1];
        for(int i = 0; i< listeTicket.Length; i++)
        {
            _listeTicket[i] = listeTicket[i];
        }

        Ticket nouveauTicker = new Ticket(voiture);
        _listeTicket[listeTicket.Length] = nouveauTicker;
        return nouveauTicker;
    }

    //Fonction qui permet de supprimer un ticket de la liste des clients
    public void SupressionDeTicket (Ticket ticket)
    {
        
           
            _listeTicket[ticket.Place] = null;
        

        
         int f =0;
         Ticket[] listeTicket = _listeTicket;
        _listeTicket = new Ticket[listeTicket.Length-1];
        for(int i = 0; i< listeTicket.Length; i++)
        {
            
            if(i !=ticket.Place)
            {
                
                listeTicket[i].Place = f;
               
             _listeTicket[f] = listeTicket[i];
             
            f++;
            }
            else
            {
                
                
            }
        }
    }

    


}