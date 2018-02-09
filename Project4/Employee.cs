using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public abstract class Employee
    {
        //fields

        private int employeeID;

        //properties

        public int EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }
        //constructors
        public Employee()
        {
            //default constructor
        }

        //methods

        public abstract int Feed();

        public abstract int GiveWater();

        public abstract void PlayWithAnimals();


    }

}
