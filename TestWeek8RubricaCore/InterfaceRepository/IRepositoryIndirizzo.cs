using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8RubricaCore.Entities;

namespace TestWeek8RubricaCore.InterfaceRepository
{
    public interface IRepositoryIndirizzo : IRepository<Indirizzo>
    {
        Indirizzo GetByIdInd(int idI);
    }
}
