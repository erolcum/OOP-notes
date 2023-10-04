
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using static Program;
using static System.Net.WebRequestMethods;

class Program
{
    public static void Main()
    {
        Pigeon joey = new Pigeon();
        Chicken lola = new Chicken();

        describe(joey);
        describe(lola);

        Console.ReadKey();
    }

    static void describe(Bird obj)
    {
        obj.talk();
        obj.fly();
    }

    public class Bird
    {
        public virtual void talk()
        { Console.WriteLine("A  Bird  Talks..."); }
        public virtual void fly()
        { Console.WriteLine("A  Bird  Flies...\n"); }
    }

    public class Pigeon : Bird
    {
        public override void talk()
        { Console.WriteLine("Pigeon Says: Coo!  Coo!"); }

        public override void fly()
        {
            Console.WriteLine("A  Pigeon  Flies  Away...");
            base.fly(); // calls base method
        }
    }

    public class Chicken : Bird
    {
        public override void talk()
        { Console.WriteLine("Chicken  Says: Cluck!  Cluck!"	); }
        public override void fly()
        {
            Console.WriteLine("I’m  A  Chicken - I Can’t Fly"	);
            base.fly();
        }
    }
}