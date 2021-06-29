using System;
using System.Collections.Generic;
using System.Text;

namespace LeZOO
{
    public class Zoo
    {

        private string _name;
        private StructAdresse _adresse;
        private Dictionary<string, Enclos> _enclos;


        /// <summary>
        /// Propriété Auto calculée de la superficie du zoo
        /// </summary>
        public double SuperficieTotale
        {
            get
            {
                double superficieZoo = 0;
                foreach (KeyValuePair<string, Enclos> item in _enclos)
                {
                    superficieZoo += item.Value.Superficie.Superficie * 2.2;
                }
                return superficieZoo;
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public StructAdresse Adresse
        {
            get { return _adresse; }
            private set { _adresse = value; }
        }

        public Dictionary<string, Enclos> Enclos { get { return _enclos; } }

        public Zoo(string nom, StructAdresse address)
        {
            this.Name = nom;
            this.Adresse = address;
            _enclos = new Dictionary<string, Enclos>();
        }

        /// <summary>
        /// Méthode afin d'ajouter des enclos 
        /// Exception créée si l'enclos existe déjà
        /// </summary>
        public void ajouter(Enclos enclos)
        {
            if (_enclos.ContainsKey(enclos.Nom))
            {
                throw new ArgumentException("L'enclos existe déjà.");
            }
            _enclos.Add(enclos.Nom, enclos);
        }





    }
}
