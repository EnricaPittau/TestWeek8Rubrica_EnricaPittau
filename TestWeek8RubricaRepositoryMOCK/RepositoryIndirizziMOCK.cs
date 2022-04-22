using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8RubricaCore.Entities;
using TestWeek8RubricaCore.InterfaceRepository;

namespace TestWeek8RubricaRepositoryMOCK
{
    public class RepositoryIndirizziMOCK : IRepositoryIndirizzo
    {
        public static List<Indirizzo> indirizzi = new List<Indirizzo>()
        {

            new Indirizzo { IdIndirizzo=1, Tipologia="Residenza", Via="Mameli", Citta="Cagliari", Cap="09564", Provincia="CA", Nazione="Italia"},
            new Indirizzo { IdIndirizzo=2, Tipologia="Domicilio", Via="Cagliari", Citta="Roma", Cap="04578", Provincia="RM", Nazione="Italia"},
            new Indirizzo { IdIndirizzo=3, Tipologia="Residenza", Via="Porto", Citta="Quartucciu", Cap="25648", Provincia="CA", Nazione="Italia"},
            
        };

        public Indirizzo Add(Indirizzo item)
        {
            if (indirizzi.Count == 0)
            {
                item.IdIndirizzo = 1;
            }
            else //se la lista è piena trova l'id più alto e, dopo aver incrementato di 1, lo assegna ad item
            {
                int maxId = 1;
                foreach (var i in indirizzi)
                {
                    if (i.IdIndirizzo > maxId)
                    {
                        maxId = i.IdIndirizzo;
                    }
                }
                item.IdIndirizzo = maxId + 1;
            }
            indirizzi.Add(item);
            return item;
        }

        public List<Indirizzo> GetAll()
        {
            return indirizzi;
        }

        public Indirizzo GetByIdInd(int idI)
        {

            foreach (var item in indirizzi)
            {
                if (item.IdIndirizzo == idI)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
