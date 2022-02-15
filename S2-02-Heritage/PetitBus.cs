public class PetitBus : Vehicule
{
    
     public PetitBus(int imatricule)
     {
         this.imatriculation = imatricule;
         this.poidAVide = 4;
         this.vitesseMax = 150;
         this.vitesse = 150;
     }

    

     public override string  ToString()
     {
           return "Imatriculation: "+ imatriculation+"\n"+"Poid à vide: "+ poidAVide+"\n"+"Vitesse maximal: "+ vitesseMax+"\n"+"Vitesse: "+ vitesse+"\n";
     }

     protected override int PoidTotal()
     {
             return this.poidAVide;
     }
}