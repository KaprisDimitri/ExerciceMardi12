using System;
class Vector
{
    //structure des vecteur 3
    public struct Vector3
    {
        public int x;
        public int y;
        public int z;

        public Vector3 (int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

// overide pour pouvoir affiché les coordonée en string
        public override string ToString()
        {
            return "{"+ x +","+ y+","+z+"}";
        }

        
//fonction pour deplacer ton vecteur
        public void Translate (Vector3 moveAdd)
        {
            x += moveAdd.x;
            y += moveAdd.y;
            z += moveAdd.z;
        }
//Distance entre 2 Vecteur
        public double Distance (Vector3 compare)
        {
                 return  MathF.Sqrt((float)((Math.Pow(compare.x,2)-Math.Pow(x,2))-(Math.Pow(compare.y,2)- Math.Pow(y,2))- (Math.Pow(compare.z,2)-Math.Pow(z,2))));
        }
//Longueur du vecteur
        public double Longueur ()
        {
                return  Math.Sqrt(Math.Pow(x,2)+ Math.Pow(y,2) +Math.Pow(z,2));
        }


    }
}