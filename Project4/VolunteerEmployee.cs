using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public class VolunteerEmployee : Employee 
    {
        //fields

        private bool likesCats;
        private bool likesDogs;

        //properties
        
        public OtherPets Mycat { get; set; }
        public OtherPets Mydog { get; set; }
        public OtherPets Mydragon { get; set; }

        public bool LikesCats
        {
            get { return this.likesCats; }
            set { this.likesCats = value; }
        }

        public bool LikesDogs
        {
            get { return this.likesDogs; }
            set { this.likesDogs = value; }
        }
        //constructors
        public VolunteerEmployee()
        {
            //default constructor
        }

        public VolunteerEmployee(int employeeID, bool likesCats, bool likesDogs)
        {
            this.EmployeeID = employeeID;
            this.likesCats = likesCats;
            this.likesDogs = likesDogs;
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

        public override int Feed ()
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
    }
}
