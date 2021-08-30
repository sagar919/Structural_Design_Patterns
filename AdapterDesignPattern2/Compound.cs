using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern2
{
    public class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected string _molecularFormula;

        // Constructor
        public Compound(string chemical)
        {
            _chemical = chemical;
        }
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} is  ", _chemical);
        }
    }
}
