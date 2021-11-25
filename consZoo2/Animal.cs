using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consZoo2
{
    public class Animal: IEat, ISleep, ISpeak
    {

        public delegate void AnimalAwaken(object source, EventArgs args);

        public event AnimalAwaken AnimalWakeup;

        public Animal(string theName, string favFood)
        {
            Name = theName;
            FavouriteFood = favFood;
        }
        private protected string FavouriteFood { get; set; }
        
        private protected string Name { get; private set; }

        public int SleepingTime { get; set; } = 0;

        protected virtual void Wokeup()
        {
            if (AnimalWakeup != null)
                AnimalWakeup(this, EventArgs.Empty);
            }

        private protected void SayName()
        {
            Console.WriteLine($"I am {Name}.");
        }

        public virtual void Eat()
        {
            SayName();
            Console.WriteLine("I eat: ");
        }
        
        public virtual async void Sleep()
        {
            await Task.Delay(300);
            SayName();
            Console.WriteLine("I sleep for: ");
            Thread.Sleep(2000);
            Wokeup();
        }

        public virtual void Speak()
        {
            SayName();
            Console.WriteLine($"I speak: ");
        }
        
    }
}
