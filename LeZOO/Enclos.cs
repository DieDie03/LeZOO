using System;

namespace LeZOO
{
    public abstract class Enclos
    {
        private string _nom;     //_nom pour s y retrouver
        private StructMesure _superficie;
        private double _temperature;

        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }
        public StructMesure Superficie
        {
            get { return _superficie; }
        }
        public string Nom                 // prop qui va interagir avec champs _nom
        {
            get { return _nom; }
        }
    }
}
