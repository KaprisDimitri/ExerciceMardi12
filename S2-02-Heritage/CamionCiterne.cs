using System;
public class CamionCiterne : Camion
{
    
    public CamionCiterne (int imatricule)
    {
        this.imatriculation = imatricule;
        this.poidAVide = 3;
        this.vitesseMax = 130;
        this.charge = 0;
        this.vitesse = CalculVitesse(PoidTotal());
        this.chargeMax = 10;
    }
    

    public override string  ToString()
     {
           return "Imatriculation: "+ imatriculation+"\n"+"Poid à vide: "+ poidAVide+"\n"+"Vitesse maximal: "+ vitesseMax+"\n"+"Vistesse: "+ vitesse + "\n"+"Charge maximal: "+ chargeMax +"\n"+"Charge: "+ charge +"\n"+"Charge restante: "+(this.chargeMax-this.charge)+"\n";
     }


     protected override int PoidTotal()
     {
             return this.charge+this.poidAVide;
     }
      protected override int CalculVitesse (int charge)
     {
         if(PoidTotal() <= this.poidAVide)
         {
             return this.vitesseMax;
         }
         else if (PoidTotal()> this.poidAVide && PoidTotal()<= 4)
         {
             return 110;
         }
         else if (PoidTotal()> 4 && PoidTotal()<= 7)
         {
             return 90;
         }
         else 
         {
             return 80;
         }
         
     }

     public override void SetCharge (int chargeToSet)
     {
         if(!(this.charge + chargeToSet > this.chargeMax))
         {
         this.charge += chargeToSet;
         this.vitesse = CalculVitesse(PoidTotal());
          Console.WriteLine(charge);
         }
         else
         {
             Console.WriteLine("Vous n'avez pas asser de place dans le camion il vous reste: "+(this.chargeMax- this.charge)+" tonnes de place");
         }
     }
}