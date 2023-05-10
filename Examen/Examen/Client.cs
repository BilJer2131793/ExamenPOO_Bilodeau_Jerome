using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Client
    {
        public string Nom { get; set; }
        public int argent { get; set; }
        static Random rand = new Random();

        public Client()
        {
            Nom = FactoryNom.FabriquerPrenom() + " " + FactoryNom.FabriquerNom();
            argent = rand.Next(5000, 50001);
        }
    }
}
