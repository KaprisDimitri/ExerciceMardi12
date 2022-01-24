using System;
unsafe class BossStruct
{
    
    public struct Boss
    {
       // string nom;
        int vieTotal;
        float vie;
        float defense;
        

        //Constructeur du boss
        public Boss (int vie, float defense)
        {
           
            //this.nom = nom;
            this.vieTotal = vie;
            this.vie = this.vieTotal;
            this.defense = defense;
            this.defense = DefenseSetUp(this.defense);
        }
         //Fonction qui permet d'avoir une defense entre 1 et 0.1
        float DefenseSetUp (float defense)
        {
            if(defense >1)
            {
                return 1;
            }
            else if( defense <0.1)
            {
                return 0.1f;
            }
            else
            {
                return defense;
            }
        }
        //Fonction qui verifie si le boss est toujours vivant
        bool VivantOuNon ()
        {
            if(vie <=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Fonction qui annonce que le boss est mort
        void LeBossEstMort()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Le boss est mort!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Fonction qui permet d'attaquer le boss et de retourner les degat infligé
        public float AttackLeBoss (float degats)
        {
            float degatsInfliger = 0;
            if(VivantOuNon())
            {
                degatsInfliger = degats * defense;
                EnleverVie(degatsInfliger);
                return degatsInfliger;
            }
            else
            {
                LeBossEstMort();
                return 0;
            }
        }
        //FOnction qui permet de retirer de la vie au boss
        void EnleverVie (float degatsInfliger)
        {
            vie -= degatsInfliger;
            if(vie <=0)
            {
                LeBossEstMort();
            }
        }

        //Fonction qui permet d'avoir les infos sur le boss
        public void InfosSurLeBoss()
        {
              Console.WriteLine("--------Infos sur le Boss-----------");
            //  Console.WriteLine("Nom : "+ nom);
              Console.WriteLine("Vie : "+ vie+"/"+ vieTotal);
              Console.WriteLine("Defense : "+ defense);
              Console.WriteLine("-----------------------------------------");
        }
    }
}