using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek8RubricaCore.Entities
{
    public class Indirizzo
    {
        public int IdIndirizzo { get; set; }
        public string Tipologia { get; set; }
        public string Via { get; set; }
        public string Citta { get; set; }
        public string Cap { get; set; }
        public string Provincia { get; set; }
        public string Nazione { get; set; }
        //FK
        public int IdContatto { get; set; }
        public Indirizzo()
        {

        }
        public override string ToString()
        {
            
            return $"Id: {IdIndirizzo}\t Tipologia: {Tipologia}\t Via: {Via} \t Città: {Citta}\t Cap: {Cap}\t Provincia: {Provincia}\t Nazone: {Nazione}";
        }
    }
}
