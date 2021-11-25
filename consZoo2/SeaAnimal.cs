using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consZoo2
{
    class SeaAnimal : Animal, ISwim
    {
        public SeaAnimal(string theName, string favFood, int noOfFinns)
            : base(theName, favFood)
        {
            NumberOfFinns = noOfFinns;
            SleepingTime = 1;  // Setting new default sleeping time for sea animal.
        }

        
        public int NumberOfFinns { get; set; }

        public void Swim()
        {
            SayName();
            Console.WriteLine($"I swim moving my {NumberOfFinns} finns");
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
            Console.Write("Blob blob");
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
