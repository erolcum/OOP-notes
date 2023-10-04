
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
        Caller call = new Caller();

        call.describe(joey);
        call.describe(lola);

        Console.ReadKey();
    }

    public sealed class Caller // can not derive from, it is sealed
    {
        public void describe(Bird obj)
        {
            obj.talk();
            obj.fly();
            obj.cry();
        }
    }

    public abstract class Bird // can not create an instance, it is abstract
    {
        public abstract void talk();
        public abstract void fly();
        public virtual void cry() // common codes for derived classes
        { Console.WriteLine("A  Bird  cries...\n"); }
    }


    public class Pigeon : Bird
    {
        public override void talk()
        { Console.WriteLine("Pigeon Says: Coo!  Coo!"); }

        public override void fly()
        {
            Console.WriteLine("A  Pigeon  Flies  Away...");
            //base.fly(); // can not call an abstract base method
        }
    }

    public class Chicken : Bird
    {
        public override void talk()
        { Console.WriteLine("Chicken  Says: Cluck!  Cluck!"	); }
        public override void fly()
        {
            Console.WriteLine("I’m  A  Chicken - I Can’t Fly"	);
        }
    }
}