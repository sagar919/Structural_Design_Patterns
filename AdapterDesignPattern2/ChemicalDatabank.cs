using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern2
{
    class ChemicalDatabank
    {

        // databank 'legacy API'
        public float GetCriticalPoint(string compound, string point)
        {

            // Melting Point
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }

            // Boiling Point
            else
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }
        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}

