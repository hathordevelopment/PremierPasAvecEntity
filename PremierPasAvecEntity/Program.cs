using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierPasAvecEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var entities = new MaPremiereBDDEntities())
            {
                var clientAAjouter = new Client()
                {
                    Nom = "TestAjoutNom",
                    Prenom = "TestAjoutPrenom",
                    Age = 41,
                    Sexe = "M"
                };

                entities.Clients.Add(clientAAjouter);

                entities.SaveChanges();

                foreach (var client in entities.Clients.Where((client) => client.Sexe == "M"))
                {
                    Console.WriteLine($"Nom : {client.Nom}, Prénom : {client.Prenom}, Age : {client.Age}, Sexe : {client.Sexe}");
                }
            }

            Console.ReadLine();
        }
    }
}
