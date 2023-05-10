using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Examen
{
    public class VTT : VehiculeMotorise
    {
        public Roue roue { get; set; }

        public VTT(string nom, string marque, int prix, Moteur moteur, Roue roue) : base(nom, marque, prix, moteur)
        {
            this.roue = roue;
        }
        public VTT(string nom, string marque, int prix, Moteur moteur) : base(nom, marque, prix, moteur)
        {
            roue = new Roue("NoName", 15);
        }
        public override string ToString()
        {
            return $"Nom : {Nom}  Marque : {Marque}   Prix : {Prix}\n" +
                $"Information sur le moteur\n" +
                $"Marque : {moteur.Marque}  HP : {moteur.Force} Refroidisment : {moteur.Refroidisment.Humanize()}\n" +
                $"Information des Roues\n" +
                $"Marque : {roue.Marque}    Grandeur : {roue.Grandeur}";
        }
    }
}
