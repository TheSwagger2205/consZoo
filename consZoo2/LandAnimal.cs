using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consZoo2
{
    public class LandAnimal : Animal, IWalk
    {
        public LandAnimal(string theName, string favFood, int noOfLegs)
            : base(theName, favFood)
        {
            NumberOfLegs = noOfLegs;
            SleepingTime = 20;  // Setting new default sleeping time for land animal.
        }

        public int NumberOfLegs { get; set; }

        public override void Eat()
        {
            base.Eat();
            Console.Write(FavouriteFood);
            Console.WriteLine();
        }

        public override void Speak()
        {
            base.Speak();
            Console.Write("Vov vov");
            Console.WriteLine();
        }
        public void Walk()
        {
            SayName();
            Console.Write($"I walk on my: \n{NumberOfLegs} legs");
            Console.WriteLine();
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.Write($"{SleepingTime} hours");
            Console.WriteLine();
        }

    }
}
