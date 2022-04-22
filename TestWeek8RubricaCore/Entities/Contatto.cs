using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek8RubricaCore.Entities
{
    public class Contatto
    {
        public int IdContatto { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Contatto()
        {

        }
        public override string ToString()
        {
            return $"L'Id del contatto è:{IdContatto}\tNome:{Nome}\tcognome: {Cognome}";
        }
    }
}
