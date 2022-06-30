using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal, ILand
    {
        public const int numberOfLegs = 4;
        //A constructor that inherrit from animal's ctor 
        public Dog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
        }
        //Methods that override animal’s implementation
        public override void SayHello()
        {
            Console.WriteLine("'wagging its tail'");
        }
        //Method that override animal’s implementation
        public override void SayHello(int mood)
        {
            switch (mood)
            {
                case mood_happy:
                    Console.WriteLine("bark loudly");
                    break;
                case mood_scare:
                    Console.WriteLine("'whooping' sound");
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
