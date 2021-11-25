using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consZoo2
{
    public class AirAnimal: Animal, IFly
    {
        public AirAnimal(string theName, string favFood, int noOfWings)
            : base(theName, favFood)
        {
            NumberOfWings = noOfWings;
            SleepingTime = 10;  // Setting new default sleeping time for air animal.
        }


        public int NumberOfWings { get; set; }

        public void Fly()
        {
            Console.WriteLine($"I {Name} fly by falpping my {NumberOfWings} wings");
        }

        public override void Eat()
        {
            base.Eat();
            Console.Write(FavouriteFood);
            Console.WriteLine();
        }

        public override void Speak()
        {
            base.Speak();
            Console.Write("Pip pip");
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
