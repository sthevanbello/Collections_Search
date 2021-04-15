using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCollections
{
    class Month
    {
        public string Name { get; private set; }
        public int Days { get; private set; }

        public Month(string name, int days)
        {
            Name = name;
            Days = days;
        }

        public override string ToString()
        {
            return $"Month: {Name.PadRight(12)}{Days} days";
        }
    }
}
