using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Registery
{
    abstract class Employee
    {

        string name;

        public Employee(string name)
        {
            name = this.name;
        }

        public abstract double calculateSalary();

    }
}
