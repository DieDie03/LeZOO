using System;

namespace LeZOO
{
    public abstract class Enclos
    {
        private string _nom;
        private double _temperature;
        private StructMesure _superficie;

        public StructMesure Superficie
        {
            get { return _superficie; }
            set { _superficie = Superficie; }
        }

        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public string Nom
        {
            get { return _nom; }
        }

        public Enclos(string nom, double temperature, double longueur, double largeur)
        {
            if (longueur < 2 && largeur < 2)
            {
                throw new ArgumentOutOfRangeException("Bad Value MIN 2mètres");
            }
            this._nom = nom;
            this._temperature = temperature;
            this._superficie.Longueur = longueur;
            this._superficie.Largeur = largeur;
        }

    }
}
