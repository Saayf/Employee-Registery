using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Registery
{
    class Clerk : Employee
    {

        string name;
        double monthlySalary;

        public Clerk(string name, double monthlySalary) : base(name)
        {
            this.name = name;
            this.monthlySalary = monthlySalary;
        }

        public override double calculateSalary()
        {
            return monthlySalary;
        }

        public override string ToString()
        {
            return name + ": (Clerk)";
        }

    }
}
