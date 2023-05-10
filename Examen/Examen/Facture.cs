using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Facture
    {
        public string Nom { get; set; }
        public DateTime date { get; set; }
        public VehiculeMotorise vehicule { get; set; }

        public Facture(string nom, VehiculeMotorise vehicule)
        {
            Nom = nom;
            date = DateTime.Now;
            this.vehicule = vehicule;
        }

        public override string ToString()
        {
            return $"**************** INFORMATION FACTURE ****************\n" +
                $"Date : {date}\n" +
                $"Client Info: \n" +
                $"Nom {Nom}\n" +
                $"Vehicule INFO: \n" +
                $"{vehicule}\n";
        }



    }
}
