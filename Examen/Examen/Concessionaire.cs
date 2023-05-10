using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Concessionaire
    {
        public string Nom { get; set; }
        public List<VehiculeMotorise> Vehicules { get; set; }
        public int MontantArgent { get; set; }

        public Concessionaire(string nom, int montantArgent)
        {
            Nom = nom;
            Vehicules = new List<VehiculeMotorise>();
            MontantArgent = montantArgent;

            RemplirInventaire();
        }
        public Concessionaire(string nom, List<VehiculeMotorise> vehicules, int montantArgent)
        {
            Nom = nom;
            Vehicules = vehicules;
            MontantArgent = montantArgent;
        }
        public void AjouterVehicle(VehiculeMotorise v)
        {
            Vehicules.Add(v);
        }
        public void VendreVehicle(VehiculeMotorise v)
        {
            Vehicules.Remove(v);
        }
        public string GetInfoInventaire()
        {
            return "";
        }
        public void RemplirInventaire()
        {
            Vehicules.Add(new Motomarine("Spark", "Google", 7299, new Moteur()));
            Vehicules.Add(new Motomarine("Spark Trixx", "Google", 1200, new Moteur(), TypeMoto.SeaDoo));
            Vehicules.Add(new Motomarine("GTR", "Costco", 16499, new Moteur()));
            Vehicules.Add(new Motomarine("RXP-X", "Costco", 20199, new Moteur(), TypeMoto.SeaDoo));
            Vehicules.Add(new Motomarine("Wake", "Dollorama", 15999, new Moteur()));

            Vehicules.Add(new VTT("CForce 500", "Honda", 9000, new Moteur()));
            Vehicules.Add(new VTT("KingQuad 500", "Suzuki", 11000, new Moteur()));
            Vehicules.Add(new VTT("KingQuad 750", "Suzuki", 15000, new Moteur()));
            Vehicules.Add(new VTT("Sportman", "Polaris", 13000, new Moteur()));
        }
        public override string ToString()
        {
            return $"INFORMATIONS SUR LE CONCESSIONAIRE\n" +
                $"Nom : {Nom}   MontantFinal : {MontantArgent}";
        }
    }
}
