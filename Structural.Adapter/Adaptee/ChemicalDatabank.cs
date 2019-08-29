using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Adapter.Adaptee
{
    public enum ChemicalPoints
    {
        BOLING_POINT,
        MELTING_POINT
    }

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class ChemicalDatabank
    {
        // The databank 'legacy API'

        public float GetCriticalPoint(string compound, ChemicalPoints point)
        {
            // Melting Point
            if (point == ChemicalPoints.MELTING_POINT)
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            else // Boiling Point
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound)
        {
            //Return chemical structure
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return String.Empty;
            }
        }

        public double GetMolecularWeight(string compound)
        {
            //Return molecule weight
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}
