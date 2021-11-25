using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    class Customer : Person
    {
        int Creditcard;

        public Customer(string name, int id) : base(name, id)
        {
        }

    }
}
