using System;
unsafe class PlayerStruct
{
       public struct Player
    {
        //Variable de la structur
        public string nom;
        float nombreDeDegats;
        BossStruct.Boss* boss;
        

        //Constructeur du Player
        public Player (string nom, int nombreDeDegats, BossStruct.Boss* boss)
        {
            this.nom = nom;
            this.nombreDeDegats = nombreDeDegats;
            this.boss = boss;
        }
        //Fonction qui permet d'attacker le boss (pointer)
        public void Attack ()
        {
            float degatInfliger;
            //appel de la fonction AttackLeBoss dans la structure et affectation de sont retour a la variable degatInfliger
            degatInfliger = boss->AttackLeBoss(nombreDeDegats);
            Console.WriteLine(nom + " a infligé "+ degatInfliger + " au boss");
        }
    }
}