 using System;
 public class CamionBache : Camion
{
    public CamionBache(int imatricule)
    {
         this.imatriculation = imatricule;
         this.poidAVide = 4;
         this.vitesseMax = 130;
         this.charge = 0;
         this.vitesse = CalculVitesse(PoidTotal());
         this.chargeMax = 20;
    }
    

    public override string  ToString()
     {
           return "Imatriculation: "+ imatriculation+"\n"+"Poid à vide: "+ poidAVide+"\n"+"Vitesse maximal: "+ vitesseMax+"\n"+"Vistesse: "+ vitesse + "\n"+"Charge maximal: "+ chargeMax +"\n"+"Charge: "+ charge +"\n"+"Charge restante: "+(this.chargeMax-this.charge)+"\n";
     }

     public override void SetCharge (int chargeToSet)
     {
         if(!(this.charge + chargeToSet > this.chargeMax))
         {
         this.charge += chargeToSet;
         this.vitesse = CalculVitesse(PoidTotal());
         }
         else
         {
             
             Console.WriteLine("Vous n'avez pas asser de place dans le camion il vous reste: "+(this.chargeMax- this.charge)+" tonnes de place");
         }
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
         else if (PoidTotal()> this.poidAVide && PoidTotal()<= 7)
         {
             return 110;
         }
         else if (PoidTotal()> 7 && PoidTotal()<= 11)
         {
             return 90;
         }
         else if (PoidTotal()> 11 && PoidTotal()<= 14)
         {
             return 80;
         }
         else
         {
             return 70;
         }   
     }
}