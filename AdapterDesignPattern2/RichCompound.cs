using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern2
{
    public class RichCompound : Compound
    {
        private ChemicalDatabank _bank;

        public RichCompound(string name): base(name)
        { 
        }
        public override void Display()
        {
            // Adaptee
            _bank = new ChemicalDatabank();
            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularFormula = _bank.GetMolecularStructure(_chemical);
            base.Display();
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
    }
}
