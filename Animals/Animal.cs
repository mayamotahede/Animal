using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        public bool Mammals { get; set; }
        public bool Carnivorous { get; set; }
        public const int mood_happy = 1;
        public const int mood_scare = 2;
        private int mood;

        //The property of set validates the data and display a message if the number of mood is invalid.
        public int Mood
        {
            get
            {
                return mood;
            }
            set
            {
            if(value.Equals(1) || value.Equals(2))
                {
                mood = value;
                }
            else
                {
                    Console.WriteLine("invalid mood value");
                    //throw new ArgumentOutOfRangeException("value");
                    
                }
            }
        }
        //A base constructor
        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.Mammals = mammals;
            this.Carnivorous = carnivorous;
            this.Mood = mood;
        }
     
        public virtual void SayHello()
        {
        }
        public abstract void SayHello(int mood);
        
        public bool IsMammals()
        {
            return Mammals;
        }
        //property can be used instead
        public void SetMammals(bool mammals)
        {
            Mammals = mammals;
        }
        public bool IsCarnivorous()
        {
            return Carnivorous;
        }
        //property can be used instead
        public void SetCarnivorous(bool carnivorous)
        {
            Carnivorous = carnivorous;
        }
    }
}
       
    

