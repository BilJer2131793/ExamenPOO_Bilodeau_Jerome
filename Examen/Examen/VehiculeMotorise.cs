using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class VehiculeMotorise
    {
        public string Nom { get; set; }
        public string Marque { get; set; }
        public int Prix { get; set; }
        public Moteur moteur { get; set; }

        protected VehiculeMotorise (string nom, string marque, int prix, Moteur moteur)
        {
            Nom = nom;
            Marque = marque;
            Prix = prix;
            this.moteur = moteur;
        }
    }
}
