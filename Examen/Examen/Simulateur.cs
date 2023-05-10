using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Examen
{
    public class Simulateur
    {
        Concessionaire MonConcessionaire { get; set; }
        static Random rand = new Random();
        public void Simuler()
        {
            MonConcessionaire = new Concessionaire("Sport MotoMarine", 0);
            List<Client> listClient = GenererListClient();
            SimulerTransaction(listClient);


        }
        public List<Client> GenererListClient()
        {
            int num = rand.Next(1, 6);
            List<Client> listClient = new List<Client>();
            for (int i = 0; i < num; i++)
            {
                listClient.Add(new Client());
            }
            return listClient;

        }
        public void SimulerTransaction(List<Client> listClient)
        {
            foreach (Client c in listClient)
            {
                Transaction(c);
            }
            Console.WriteLine(MonConcessionaire);

        }
        public void Transaction(Client c)
        {
            try
            {
                int counter = 0;
                int num = rand.Next(0, 2);
                int[] numVehicule = new int[2];
                for (int i = 0; i < MonConcessionaire.Vehicules.Count()&&counter<2; i++)
                {
                    if (num == 0)
                    {
                        if (MonConcessionaire.Vehicules[i] is Motomarine)
                        {
                            numVehicule[counter] = i;
                            counter++;

                        }

                    }
                    else
                    {
                        if (MonConcessionaire.Vehicules[i] is VTT)
                        {
                            numVehicule[counter] = i;
                            counter++;
                        }

                    }
                }
                if (counter > 2)
                    throw new Exception("L'inventaire est vide pour ce type de produit");
                TentezVente(numVehicule, c);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void TentezVente(int[] numVehicule, Client c)
        {
            VehiculeMotorise v1 = MonConcessionaire.Vehicules[numVehicule[0]];
            VehiculeMotorise v2 = MonConcessionaire.Vehicules[numVehicule[1]];
            try
            {
                if (v1.moteur > v2.moteur)
                {
                    if (v1.Prix <= c.argent)
                    {
                        MonConcessionaire.Vehicules.Remove(v1);
                        Console.WriteLine(new Facture(c.Nom, v1));
                    }
                    else
                    {
                        throw new Exception("Le client n'a pas les moyens");

                    }
                }
                else
                {
                    if(v2.Prix <= c.argent)
                    {
                        MonConcessionaire.Vehicules.Remove(v2);
                        Console.WriteLine(new Facture(c.Nom, v2));
                    }
                    else
                    {
                        throw new Exception("Le client n'a pas les moyens");

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Client INFO: \n" +
                                 $"{c.Nom}\n");
            }
        }
    }
}
