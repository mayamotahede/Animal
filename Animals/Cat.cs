using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Animal, ILand
    {
        public const int numberOfLegs = 4;
        //A constructor that inherrit from animal's ctor
        public Cat(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
        }
        //Methods that override animal’s implementation
        public override void SayHello()
        {
            Console.WriteLine("'meow'");
        }
        //Method that override animal’s implementation
        public override void SayHello(int mood)
        {
            switch (mood)
            {
                case mood_happy:
                    Console.WriteLine("'purr,purr' sound");
                    break;
                case mood_scare:
                    Console.WriteLine("'hiss' sound");
                    break;
            }
        }
        // Implementation of Land interface
        public int GetNumberOfLegs()
        {
            return (numberOfLegs);
        }      
    }
}
