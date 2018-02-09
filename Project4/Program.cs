using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet Mydragon = new VirtualPet(string.Empty, "red and scary", 50, 50);
            OtherPets Mycat = new OtherPets("cat", string.Empty, "tuxedo", "canned food", 50, 50);
            OtherPets Mydog = new OtherPets("dog", string.Empty, "black lab", "dry food", 50, 50);
            VolunteerEmployee Vol1 = new VolunteerEmployee(1001, true, true);
            VolunteerEmployee Vol2 = new VolunteerEmployee(1002, true, true);
            VolunteerEmployee Vol3 = new VolunteerEmployee(1003, true, true);


            List<VolunteerEmployee> EmployeeList = new List <VolunteerEmployee> ();
            List<VirtualPet> PetList = new List<VirtualPet>();

            EmployeeList.Add(Vol1);
            EmployeeList.Add(Vol2);
            EmployeeList.Add(Vol3);
            PetList.Add(Mydragon);
        }
    }
}
