using System;
using System.Collections.Generic;
using System.Text;

namespace LeZOO
{
    public class Zoo
    {
        private string _name;
        private StructAdresse _adresse;
        private double _superficieZoo;

        public double SuperficieZoo
        {
            get { return _superficieZoo; }
        }
        public StructAdresse Adresse
        {
            get { return _adresse; }
        }
        public string Name
        {
            get { return _name; }
        }

        public List<Enclos> Enclos = new List<Enclos>(); // Variable ou instancier les enclos 
    }
}
