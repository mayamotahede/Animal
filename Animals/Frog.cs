using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal, ILand, IWater
    {
        public const int numberOfLegs = 4;
        //A constructor that inherrit from animal's ctor
        public Frog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
        }
        //Method that override animal’s implementation
        public override void SayHello(int mood)
        {
            switch (mood)
            {
                case mood_happy:
                    Console.Write("'quack quack quack' ");
                    break;
                case mood_scare:
                    Console.WriteLine("'plop into the water'");
                    break;
            }
        }
        // Implementation of Water interface
        public bool HasGills()
        {
            return true;
        }

        public bool HasLaysEggs()
        {
            return true;
        }
        // Implementation of Land interface
        public int GetNumberOfLegs()
        {
            return (numberOfLegs);
        }

    }
}
