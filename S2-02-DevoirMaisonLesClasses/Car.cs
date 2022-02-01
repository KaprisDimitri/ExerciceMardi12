public class Car
{
    //Proprieter de la class Car
    string _nomDuProprietaire;
    
    //Constructeur de la class Car
    public Car (string nomDuProprietaire)
    {
         _nomDuProprietaire = nomDuProprietaire;
    }
    // Accesor permet de recupérer la valeur des proprieter de la class Car
    public string NomDuProprietaire
    {
        get
        {
            return _nomDuProprietaire;
        }
    }
}
