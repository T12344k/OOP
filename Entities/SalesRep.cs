using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SalesRep : Employee
    {//declaring commision rate
        public double Commissionrate { get; set; }


        public SalesRep(string name, int id, double salary) : base(salary, id ,name)
        {
            Commissionrate = salary;
        }
    }
}

