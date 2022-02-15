using System.Collections.Generic;
using System;
class Convoi
{
    List<Vehicule> convoi;

    public Convoi ()
    {
        convoi = new List<Vehicule>();
    }

    public List<Vehicule> Convoie
    {
        get
        {
            return convoi;
        }
    }

    public void AjouterVehicule (Vehicule ajout)
    {
        convoi.Add(ajout);
    }

    public bool RetirerVehicule (Vehicule ajout)
    {
        int index = IndexCelonImatriculation(ajout.Imatriculation);
        if(index != -1)
        {
             RecreationDeList(index);
             return true;
        }
        return false;

    }

    public bool RetirerVehiculeCelonImatricule (int ajout)
    {
        int index = IndexCelonImatriculation(ajout);
        if(index != -1)
        {
             RecreationDeList(index);
             return true;
        }
        return false;

    }


    void RecreationDeList (int index)
    {
        List<Vehicule> sauv = new List<Vehicule>();
        for(int i =0; i<convoi.Count;i++)
        {
            if(i!=index)
            {
                sauv.Add(convoi[i]);
            }
        }

        convoi = new List<Vehicule>();
        convoi = sauv;
    }

    int IndexCelonImatriculation (int imatriculation)
    {
        for(int i = 0; i<convoi.Count;i++)
        {
              if(imatriculation == convoi[i].Imatriculation)
              {
                  return i;
              }
        }

        return -1;
    }

    public void AjoutConvoi (Convoi convoiAjout)
    {
        List<Vehicule> convoi2 = convoiAjout.Convoie;
        for(int i = 0;i<convoi2.Count; i++)
        {
            convoi.Add(convoi2[i]);
        }
    }

     int VitesseDuConvoi ()
    {
        int vitesse = 1000;
        for(int i = 0;i<convoi.Count; i++)
        {
            if(convoi[i].Vitesse < vitesse)
            {
                vitesse = convoi[i].Vitesse;
            }
        }

        if(convoi.Count ==0)
        {
            vitesse = 0;
        }
        return vitesse;
    }

    public override string ToString()
    {
        string info = HelpForme.RetourDuneStringDansUnBloque("La vitesse du convoie est de :"+ VitesseDuConvoi())+"\n";
        
        for(int i = 0;i<convoi.Count;i++)
        {
            info += convoi[i].ToString()+"\n";
        }
        return info;
    }

}