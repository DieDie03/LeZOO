using System;
using System.Collections.Generic;
using System.Text;

namespace LeZOO
{
    public struct StructMesure
    {
        public double Longueur { get; }
        public double Largeur { get; }
        public double Hauteur { get; }

        public double Superficie { get { return Longueur* Largeur; } } // Propriété auto-calculée
        public double Volume { get { return Longueur * Largeur * Hauteur; } } // Propriété auto-calculée

    }
}
