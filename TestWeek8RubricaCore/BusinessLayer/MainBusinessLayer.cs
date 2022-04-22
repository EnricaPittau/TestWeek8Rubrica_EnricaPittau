using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8RubricaCore.Entities;
using TestWeek8RubricaCore.InterfaceRepository;

namespace TestWeek8RubricaCore.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryContatto contattiRepo;
        private readonly IRepositoryIndirizzo indirizziRepo;
        public MainBusinessLayer(IRepositoryContatto contatti, IRepositoryIndirizzo indirizzi )
        {
            contattiRepo = contatti;
            indirizziRepo = indirizzi;
        }
        public List<Contatto> GetAllContatti()
        {
            return contattiRepo.GetAll();
        }

        public Esito InserisciNuovoContatto(Contatto nuovoContatto)
        {
            contattiRepo.Add(nuovoContatto);
            return new Esito { Messaggio = "Contatto inserito", IsOk = true };
        }
    }
}
