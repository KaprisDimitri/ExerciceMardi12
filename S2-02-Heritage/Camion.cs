public abstract class Camion : Vehicule
{
      protected int charge;
      protected int chargeMax;


      public int ChargeMax
     {
          get
          {
               return chargeMax;
          }
     }
      protected abstract int CalculVitesse(int charge);

      
      public abstract void SetCharge (int chargeToSet);

}