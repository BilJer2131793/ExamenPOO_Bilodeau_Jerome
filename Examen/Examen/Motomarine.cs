using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Examen
{
    public enum TypeMoto
    {
        JetSki,
        SeaDoo
    }
    public class Motomarine : VehiculeMotorise
    {
        public TypeMoto Type { get; set; }
        public Motomarine(string nom, string marque, int prix, Moteur moteur, TypeMoto type = TypeMoto.SeaDoo) : base(nom, marque, prix, moteur)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Nom : {Nom}  Marque : {Marque}   Prix : {Prix}\n" +
                $"Information sur le moteur\n" +
                $"Marque : {moteur.Marque}  HP : {moteur.Force} Refroidisment : {moteur.Refroidisment.Humanize()}\n";
        }
    }
}
