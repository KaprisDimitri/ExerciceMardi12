using System;

namespace ExerciceCharactereValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Appuyez sur une lettre");
            ConsoleKeyInfo lettreToTouch = Console.ReadKey();
            if (((byte)lettreToTouch.Key) >=65 && ((byte)lettreToTouch.Key) <= 90)
            {
            Console.WriteLine("\nVous avez appuyé sur la touche "+lettreToTouch.Key+" sa valeur numérique est de "+((byte)lettreToTouch.Key));
            }
            else
            {
                Console.WriteLine("désoler ce n'est pas une lettre");
            }
        }
    }
}
