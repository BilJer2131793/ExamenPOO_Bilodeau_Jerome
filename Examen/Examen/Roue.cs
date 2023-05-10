using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public  class Roue
    {
        public string Marque { get; set; }
        public int Grandeur { get; set; }
        public Roue(string marque, int grandeur)
        {
            Marque = marque;
            Grandeur = grandeur;
        }
    }
}
