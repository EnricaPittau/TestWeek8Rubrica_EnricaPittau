using TestWeek8RubricaCore.Entities;
using TestWeek8RubricaCore.InterfaceRepository;

namespace TestWeek8RubricaRepositoryMOCK
{
    public class RepositoryContattiMOCK : IRepositoryContatto
    {
        public static List<Contatto> contatti = new List<Contatto>()
        {

            new Contatto { IdContatto=1, Nome="Manuel", Cognome="Mameli"},
            new Contatto { IdContatto=2, Nome="Luca", Cognome="Cianciolo"},
            new Contatto { IdContatto=3, Nome="Simone", Cognome="Belli"}
        };
        public Contatto Add(Contatto item)
        {
            if (contatti.Count == 0)
            {
                item.IdContatto = 1;
            }
            else
            {
                int idMax = 1;
                foreach (var c in contatti)
                {
                    if (c.IdContatto>idMax)
                    {
                        idMax=c.IdContatto;
                    }

                }
                item.IdContatto = idMax + 1;
            }
            contatti.Add(item);
            return item;
        }

        public bool Delete(Contatto contatto)
        {
            contatti.Remove(contatto);
            return true;
        }

        public List<Contatto> GetAll()
        {
            return contatti;
        }

        public Contatto GetByIdCon(int idC)
        {
            foreach (var item in contatti)
            {
                if (item.IdContatto == idC)
                {
                    return item;
                }
            }
            return null;
        }
    }
}