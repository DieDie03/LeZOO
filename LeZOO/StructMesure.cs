using System;
using System.Collections.Generic;
using System.Text;

namespace LeZOO
{
    public struct StructMesure
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }
        public double Hauteur { get; set; }

        public double Superficie { get { return Longueur* Largeur; } } // Propriété auto-calculée
        public double Volume { get { return Longueur * Largeur * Hauteur; } } // Propriété auto-calculée

    }
}
