public abstract class  Vehicule
{
     protected int imatriculation;
     protected int vitesseMax;
     protected int poidAVide;

     protected int vitesse;

     public int Vitesse
     {
          get
          {
               return vitesse;
          }
     }

     public int Imatriculation
     {
          get
          {
               return imatriculation;
          }
     }
     

     public abstract override string ToString();

     

     protected abstract int PoidTotal();

}