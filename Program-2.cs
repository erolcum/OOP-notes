
using System.Diagnostics;
using System.IO;
using static Program;

class Program
{
    public static void Main()
    {
        Man henry = new Man();
        Hombre enrique = new Hombre();

        henry.speak();
        henry.speak("It’s a beautiful evening"	);

        enrique.speak("Hola...");
        ((Man)enrique).speak("Ne diyon kardeşim"); // explicit cast

        Console.ReadKey();
    }

    public class Man
    {
        public void speak()
        {
            Console.Write("Hello: ");
        }
        public void speak(string message)
        {
            Console.WriteLine(message + "!\n"	);
        }
    }

    public class Hombre : Man
    {
        public new void speak(string message) // hide base method with new
        {
            base.speak(); // call base method in Man
            Console.WriteLine(message);
        }
    }


}