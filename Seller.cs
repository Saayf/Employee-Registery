using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Registery
{
    class Seller : Employee
    {

        string name;
        double commission;
        double sales;

        public Seller(string name, double commission, double sales) : base(name)
        {
            this.name = name;
            this.commission = commission;
            this.sales = sales;
        }

        public override double calculateSalary()
        {
            return sales * commission / 100;
        }

        public override string ToString()
        {
            return name + ": (Seller)"; 
        }

    }
}
