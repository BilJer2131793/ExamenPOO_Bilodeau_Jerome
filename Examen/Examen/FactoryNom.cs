using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public static class FactoryNom
    {
        static List<string> listNom = new List<string>();
        static List<string> listPrenom = new List<string>();
        static Random rand = new Random();


        static public void RemplirListe()
        {
            listPrenom.Add("Jerome");
            listPrenom.Add("Vincent");
            listPrenom.Add("Louis");
            listPrenom.Add("Liam");
            listPrenom.Add("Logan");
            listPrenom.Add("Lucie");
            listPrenom.Add("Melanie");
            listPrenom.Add("Sylvia");


            listNom.Add("Fortin");
            listNom.Add("Bilodeau");
            listNom.Add("Tremblay");
            listNom.Add("Trudeau");
            listNom.Add("Leclerc");
        }

        static public string FabriquerNom()
        {
            RemplirListe();
            return listNom[rand.Next(listNom.Count)];
        }

        static public string FabriquerPrenom()
        {
            RemplirListe();
            return listPrenom[rand.Next(listPrenom.Count)];
        }
    }
}

