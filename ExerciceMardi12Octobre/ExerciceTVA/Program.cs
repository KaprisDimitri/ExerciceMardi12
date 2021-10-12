using System;


namespace ExerciceTVA
{
    class Program
    {
           static float tva = 20;
           static float tvaPremiereNecessiter = 5;
           static float produitNumeroUn = 19.64f;
           static float produitNumeroDeux = 254.50f;
           static float quantiteProduitUn = 2;
           static float quantiteProduitDeux = 2;
        static void Main(string[] args)
        {
           
           //string Tsttva = Console.ReadLine();
           AppelDesFonctions ();
        
         
        }


        static float ProduitEnCroix(float produit, float pourcent)
        {
            return((produit * pourcent) / 100);
        }

        static float Addition (float addUn, float addDeux)
        {
            return(addUn + addDeux);
        }

        static float Multiplication(float multiUn, float multiDeux)
        {
            return(multiUn * multiDeux);
        }

        static void AnnoncesEtCalcul ()
        
        {
// Calcul de Tva de chaque produit (check)
           float produitUnTva = ProduitEnCroix(produitNumeroUn, tva);
           float produitDeuxTva = ProduitEnCroix(produitNumeroDeux, tva);

//Ajout de la Tva au produit (check)
           float tvaProduitUn = Addition (produitNumeroUn, produitUnTva);
           float tvaProduitDeux = Addition (produitNumeroDeux, produitDeuxTva);

// Calcul de la TVA en Quantité (check)
           float totalTvaProduitUn = Multiplication(produitUnTva, quantiteProduitUn);
           float totalTvaProduitDeux = Multiplication(produitDeuxTva, quantiteProduitDeux);

//Multiplier le produit TTC avec la quantité (check)
           float totalQuantiteTvaProduitUn = Multiplication(tvaProduitUn, quantiteProduitUn);
           float totalQuantiteTvaProduitDeux = Multiplication(tvaProduitDeux, quantiteProduitDeux);

           // Calcul de la TVA premiere necessité (Check)
           float produitUnTvaPremiereNecessiter = ProduitEnCroix(produitNumeroUn, tvaPremiereNecessiter);
           float produitDeuxTvaPremiereNecessiter = ProduitEnCroix(produitNumeroDeux, tvaPremiereNecessiter);

           // Ajout de la Tva Premiere necessiter au produit (Check)
           float totalTvaPremiereNecessiterProduitUn = Addition (produitNumeroUn, produitUnTvaPremiereNecessiter);
           float totalTvaPremiereNecessiterProduitDeux = Addition (produitNumeroDeux, produitDeuxTvaPremiereNecessiter);

           // Multiplier le produit TTC en fonction de la quantité (Check)
           float totalQuantiteTvaPremiereNecessiterProduitUn = Multiplication(totalTvaPremiereNecessiterProduitUn, quantiteProduitUn);
           float totalQuantiteTvaPremiereNecessiterProduitDeux = Multiplication(totalTvaPremiereNecessiterProduitDeux, quantiteProduitDeux);
           // Multiplier le produit par ca quantité (check)
           float totalQuantiteProduitUn = Multiplication(produitNumeroUn, quantiteProduitUn);
           float totalQuantiteProduitDeux = Multiplication(produitNumeroDeux, quantiteProduitDeux);

           // Ajout de la TVA au produit quantifier
           /*float totalQuantiteProduitUnTva = Addition (totalQuantiteProduitUn, totalTvaProduitUn);
           float totalQuantiteProduitDeuxTva = Addition (totalQuantiteProduitDeux, totalTvaProduitDeux);*/

            // Calcul de la TVA total (check)
           float totalDesTva = Addition (totalTvaProduitDeux, totalTvaProduitUn);

            // Affichage des infos sur la console 
           Console.WriteLine("Tva Produit Un : " + produitUnTva);
           Console.WriteLine("Tva Produit Deux : " + produitDeuxTva);

           Console.WriteLine("Total Produit Un TTC : " + tvaProduitUn);
           Console.WriteLine("Total Produit Deux TTC : " + tvaProduitDeux);

            Console.WriteLine("Total Tva Produit Un : " + totalTvaProduitUn);
           Console.WriteLine("Total Tva Produit Deux : " + totalTvaProduitDeux);

           Console.WriteLine("Produit Un TTC Quantité : " + totalQuantiteTvaProduitUn);
           Console.WriteLine("Produit Deux TTC Quantité : " + totalQuantiteTvaProduitDeux);

           Console.WriteLine("Tva Premiere Necessité Produit Un : " + produitUnTvaPremiereNecessiter);
           Console.WriteLine("Tva Premiere Necessit Produit Deux : " + produitDeuxTvaPremiereNecessiter);

           Console.WriteLine("Tva Premiere Necessité Plus Produit Un : " + totalTvaPremiereNecessiterProduitUn);
           Console.WriteLine("Tva Premiere Necessit Plus Produit Deux : " + totalTvaPremiereNecessiterProduitDeux);

           Console.WriteLine("Total Tva Premiere Necessité Produit Un : " + totalQuantiteTvaPremiereNecessiterProduitUn);
           Console.WriteLine("Total Tva Premiere Necessit Produit Deux : " + totalQuantiteTvaPremiereNecessiterProduitDeux);

           Console.WriteLine("Prix HT En Quantité Produit Un : " + totalQuantiteProduitUn);
           Console.WriteLine("Prix HT En Quantité Produit Deux : " + totalQuantiteProduitDeux);

           Console.WriteLine("Total des Tva : " + totalDesTva);
        }
        
        static float DemandeUtilisateur (float demande)
        {
            if (float.TryParse(Console.ReadLine(), out demande))
          {
             
          }
          else
          {
              Console.WriteLine("Veuillez resaisir le chiffre");
             DemandeUtilisateur(demande);
          }
          return demande;
  
        }
    
        static void Incrémentation ()
    {
         Console.WriteLine("Veuillez saisir la TVA");
        tva = DemandeUtilisateur(tva);
        Console.WriteLine("Veuillez saisir la TVA de première necessiter");
        tvaPremiereNecessiter = DemandeUtilisateur(tvaPremiereNecessiter);
        Console.WriteLine("Veuillez saisir le prix du produit 1");
        produitNumeroUn = DemandeUtilisateur(produitNumeroUn);
        Console.WriteLine("Veuillez saisir le prix du produit 2");
        produitNumeroDeux = DemandeUtilisateur(produitNumeroDeux);
        Console.WriteLine("Veuillez saisir la quantité du produit 1");
        quantiteProduitUn = DemandeUtilisateur(quantiteProduitUn);
        Console.WriteLine("Veuillez saisir la quantité du produit 2");
        quantiteProduitDeux = DemandeUtilisateur(quantiteProduitDeux);

    }
    
static void Redemande()
    {
    Console.WriteLine("Voulez vous recommencé si oui tapez 1 si non tapez 0");
    int redemande;
    if (int.TryParse(Console.ReadLine(), out redemande))
          {
             if(redemande == 1)
             {
                AppelDesFonctions ();
             }
             else if (redemande == 0)
             {
                 Console.WriteLine("BonneJournée");
             }
             else
             {
                 Console.WriteLine("Veuillez resaisir le chiffre");
            Redemande();
             }
          }
          else
          {
              Console.WriteLine("Veuillez resaisir le chiffre");
            Redemande();
          }


    }
        static void AppelDesFonctions ()
    {
        Incrémentation ();
        AnnoncesEtCalcul ();
        Redemande(); 

    }

    }
}
