using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.WebAPI.Service
{
    public interface IBaseCRUDService<TModel, TSearch, TInsert, TUpdate> : IBaseGetService<TModel, TSearch>
    {
        TModel Insert(TInsert insert);
        TModel Update(int id, TUpdate request);
        bool Delete(int id);
    }
}
