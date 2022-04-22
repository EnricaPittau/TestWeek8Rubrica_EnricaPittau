using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8RubricaCore.Entities;

namespace TestWeek8RubricaCore.BusinessLayer
{
    public interface IBusinessLayer
    {
        List<Contatto> GetAllContatti(); //VisualizzaContatti();
        Esito InserisciNuovoContatto(Contatto nuovoContatto);
        //InserisciNuovoIndirizzo();
        //EliminaContattoSenzaIndirizzo();
    }
}
