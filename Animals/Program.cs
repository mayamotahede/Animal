using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog aDog = new Dog(true,true,1);
            Cat aCat = new Cat(true, true, 1);
            Frog aFrog = new Frog(false,false,1);
     
            //Testing the dog's class
            Console.Write("The dog says hello by ");
            aDog.SayHello();
            Console.Write("In good mood it will ");
            aDog.SayHello(aDog.Mood);
            aDog.Mood = 2;
            Console.Write("In scard mood it will make a ");
            aDog.SayHello(aDog.Mood);
            Console.Write("Is carnivorous: ");
            Console.WriteLine(aDog.IsCarnivorous());
            Console.Write("Is a mammal: ");
            Console.WriteLine(aDog.IsMammals());
            aDog.SetMammals(true);
            aDog.SetCarnivorous(true);
            Console.WriteLine("After SetMammals and SetCarnivorous:");
            Console.Write("Is carnivorous: ");
            Console.WriteLine(aDog.IsCarnivorous());
            Console.Write("Is a mammal: ");
            Console.WriteLine(aDog.IsMammals());
            Console.Write("The number of legs: ");
            Console.WriteLine(aDog.GetNumberOfLegs());
            Console.WriteLine("---------------------");
            //Testing the cat's class
            Console.Write("The cat says hello by ");
            aCat.SayHello();
            Console.Write("In good mood it will make a ");
            aCat.SayHello(aCat.Mood);
            aCat.Mood = 2;
            Console.Write("In scard mood it will make a ");
            aCat.SayHello(aCat.Mood);
            Console.Write("Is carnivorous: ");
            Console.WriteLine(aCat.IsCarnivorous());
            Console.Write("Is a mammal: ");
            Console.WriteLine(aCat.IsMammals());
            aCat.SetMammals(true);
            aCat.SetCarnivorous(true);
            Console.WriteLine("After SetMammals and SetCarnivorous:");
            Console.Write("Is carnivorous: ");
            Console.WriteLine(aCat.IsCarnivorous());
            Console.Write("Is a mammal: ");
            Console.WriteLine(aCat.IsMammals());
            Console.Write("The number of legs:");
            Console.WriteLine(aCat.GetNumberOfLegs());
            Console.WriteLine("---------------------");
            //Testing the frog's class
            Console.Write("In good mood the frog will sing ");
            aFrog.SayHello(aFrog.Mood);
            Console.WriteLine("on the shore");
            aFrog.Mood = 2;
            Console.Write("In scard mood it will ");
            aFrog.SayHello(aFrog.Mood);
            Console.Write("Is carnivorous: ");
            Console.WriteLine(aFrog.IsCarnivorous());
            Console.Write("Is mammal: ");
            Console.WriteLine(aFrog.IsMammals());
            aFrog.SetMammals(false);
            aFrog.SetCarnivorous(false);
            Console.WriteLine("After SetMammals and SetCarnivorous:");
            Console.Write("Is carnivorous: ");
            Console.WriteLine(aFrog.IsCarnivorous());
            Console.Write("Is mammal: ");
            Console.WriteLine(aFrog.IsMammals());
            Console.Write("The number of legs: ");
            Console.WriteLine(aFrog.GetNumberOfLegs());
            Console.Write("Is has gills: ");
            Console.WriteLine(aFrog.HasGills());
            Console.Write("Is has lays eggs: ");
            Console.WriteLine(aFrog.HasLaysEggs());
            aFrog.Mood = 4;
        }
    }
}
