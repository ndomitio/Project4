using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public class Manager : Employee
    {
        //fields
        //properties
        public bool HasAuthority { get; set; }
        public OtherPets Mycat { get; set; }
        public OtherPets Mydog { get; set; }
        public OtherPets Mydragon { get; set; }
        //constructors 

        public Manager()
        {
            //default constructor
        }

        public Manager(bool hasAuthority)
        {
            this.HasAuthority = hasAuthority;
        }

        //methods 

        public override int GiveWater()
        {
            if ((Mycat.HydrationLevel >= 40) || (Mydog.HydrationLevel >= 40) || (Mydragon.HydrationLevel >= 40))
            {
                Console.WriteLine("Looks like the animals need water!");
                return ((Mycat.HydrationLevel = 0) + (Mydog.HydrationLevel = 0) + (Mydragon.HydrationLevel = 0));
            }

            else
            {
                Console.WriteLine("Looks like everyone is good on water for now!");
                return (Mycat.HydrationLevel) + (Mydog.HydrationLevel) + (Mydragon.HydrationLevel);

            }
        }


        public override void PlayWithAnimals()
        {
            Console.WriteLine("Hope it is nice outside, the animals love the outdoors!");
        }

        public override int Feed()
        {
            if ((Mycat.Hunger >= 30) || (Mydog.Hunger >= 30) || (Mydragon.Hunger >= 30))
            {
                Console.WriteLine("Time to feed the animals!");
                return ((Mycat.Hunger = 0) + (Mydog.Hunger = 0) + (Mydragon.Hunger = 0));
            }
            else
            {
                Console.WriteLine("No one is hungry right now :( ");
                return (Mycat.Hunger) + (Mydog.Hunger) + (Mydragon.Hunger);
            }
        }

        public void Adopt()
        { } //console writeline the list and ask for user input to select and remove from list?
    }
}
