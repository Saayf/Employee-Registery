using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Registery
{
    class Consultant : Employee
    {

        string name;
        double hourlyRate;
        double timeWorked;

        public Consultant(string name, double hourlyRate, double timeWorked) : base(name)
        {
            this.name = name;
            this.hourlyRate = hourlyRate;
            this.timeWorked = timeWorked;
        }

        public override double calculateSalary()
        {
            return hourlyRate * timeWorked;
        }

        public override string ToString()
        {
            return name + ": (Consultant)";
        }

    }
}
