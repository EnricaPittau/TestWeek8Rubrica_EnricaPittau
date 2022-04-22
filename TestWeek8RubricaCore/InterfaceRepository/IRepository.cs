using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek8RubricaCore.InterfaceRepository
{
    public interface IRepository<T>
    {
        List<T> GetAll(); //solo contatti?
        T Add(T item); //per entrambi

    }
}
