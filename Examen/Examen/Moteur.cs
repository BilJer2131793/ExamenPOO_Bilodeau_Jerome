using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public enum Cooling
    {
        air,
        liquide
    }
    public class Moteur
    {
        public string Marque { get; set; }
        public int Force { get; set; }
        public Cooling Refroidisment { get; set; }
        public Moteur()
        {
            Marque = "Yamaha";
            Force = 50;
            Refroidisment = Cooling.air;
        }
        public Moteur(string marque, int force, Cooling refroidisment)
        {
            Marque = marque;
            Force = force;
            Refroidisment = refroidisment;
        }
        public static bool operator >(Moteur m1, Moteur m2)
        {
            if (m1.Force > m2.Force)
                return true;
            return false;
        }
        public static bool operator < (Moteur m1, Moteur m2)
        {
            if (m1.Force < m2.Force)
                return true;
            return false;
        }
    }
}
