using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Droid : IDroid
    {
        // assignment of the variables
        protected string material;
        protected string model;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        // The Default constructor
        public Droid(string a, string b, string c)
        {
            a = material;
            b = model;
            c = color;
        }

        // This is the property used for TotalCost by the Interface
        public decimal TotalCost
        {
            get { return totalCost; }
        }

        // the toString method goes here (easy, do later)

        // CalculateBaseCost method
        // Determines the baseCost based on material

        // CalculateTotalCost method
        // assigns baseCost to totalCost (Required by the interface)
        public virtual void CalculateTotalCost()
        {
            totalCost = baseCost;
        }
    }
}
