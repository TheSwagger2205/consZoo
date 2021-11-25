using System;
using System.Threading;
using System.Threading.Tasks;

namespace consZoo2
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            


            var ZooMaster = new ZooMaster();

            // Create LandAnimal
            LandAnimal dog1 = new("King", "Pie", 4);
            dog1.AnimalWakeup += ZooMaster.UnAnimalEncoded;
            dog1.Eat();
            dog1.Sleep();
            dog1.Speak();
            dog1.Walk();

            Console.WriteLine("------------------------------------------------------------------");
            // Create AirAnimal
            AirAnimal air1 = new("Pipper", "bananfluer",2);
            air1.AnimalWakeup += ZooMaster.UnAnimalEncoded;
            air1.Eat();
            air1.Sleep();
            air1.Speak();
            air1.Fly();

            Console.WriteLine("------------------------------------------------------------------");

            // Create SeaAnimal
            SeaAnimal sea1 = new("Blobber", "Little fish", 3);
            sea1.AnimalWakeup += ZooMaster.UnAnimalEncoded;
            sea1.Eat();
            sea1.Sleep();
            sea1.Speak();
            sea1.Swim();

            Console.ReadLine();
        }
    }
}
