using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8RubricaCore.BusinessLayer;
using TestWeek8RubricaCore.Entities;
using TestWeek8RubricaRepositoryMOCK;

namespace TestWeek8RubricaPresentation
{
    internal class Menu
    {
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryContattiMOCK(), new RepositoryIndirizziMOCK());
        //private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryCorsiADO(), new RepositoryStudentiADO());


        internal static void Start()
        {
            bool continua = true;

            while (continua)
            {
                int scelta = SchermoMenu();
                continua = AnalizzaScelta(scelta);
            }
        }
        private static bool AnalizzaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    VisualizzaContatti();
                    break;
                case 2:
                    InserisciNuovoContatto();
                    break;
                case 3:
                    //InserisciNuovoIndirizzo();
                    break;
                case 4:
                    //EliminaContattoSenzaIndirizzo();
                    break;        
                case 0:
                    return false;
                default:
                    Console.WriteLine("Scelta errata. Inserisci scelta corretta: ");
                    break;
            }
            return true;
        }
        private static int SchermoMenu()
        {
            Console.WriteLine("******************MENU*****************");          
            Console.WriteLine("1.Visualizza Contatti");
            Console.WriteLine("2.Inserisci nuovo Contatto");
            Console.WriteLine("3.Inserisci nuovo Indirizzo");
            Console.WriteLine("4.Elimina Contatto senza indirizzo");
            Console.WriteLine("\n0. Exit");

            int scelta;
            Console.WriteLine("Inserisci la tua scelta: ");
            while (!(int.TryParse(Console.ReadLine(), out scelta)))
            {
                Console.WriteLine("Scelta errata. Inserisci scelta corretta: ");
            }

            return scelta;
        }
        private static void VisualizzaContatti()
        {
            List<Contatto> contatti = bl.GetAllContatti();
            if (contatti.Count == 0)
            {
                Console.WriteLine("Nessuno contatto presente");
            }
            else
            {
                foreach (var item in contatti)
                {
                    Console.WriteLine(item);
                }
            }
        }
        private static void InserisciNuovoContatto()
        {
            
            Console.WriteLine("Inserisci nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome");
            string cognome = Console.ReadLine();                   
            
            Contatto nuovoContatto = new Contatto();
            nuovoContatto.Nome = nome;
            nuovoContatto.Cognome = cognome;
            
            Esito esito = bl.InserisciNuovoContatto(nuovoContatto);
            Console.WriteLine(esito.Messaggio);
        }


    }
}
