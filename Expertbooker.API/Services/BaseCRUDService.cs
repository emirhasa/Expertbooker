using AutoMapper;
using EkspertBooker.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.WebAPI.Service
{
    public class BaseCRUDService<TModel, TSearch, TInsert, TUpdate, TDatabase> : BaseGetService<TModel, TSearch, TDatabase>, IBaseCRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase: class
    {
        public BaseCRUDService(EkspertBookerContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(TInsert request)
        {
            try
            {
                var entity = _mapper.Map<TDatabase>(request);

                _context.Set<TDatabase>().Add(entity);
                _context.SaveChanges();

                return _mapper.Map<TModel>(entity);
            }
            catch {
                throw;
            }
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            try
            {
                var entity = _context.Set<TDatabase>().Find(id);

                _mapper.Map(request, entity);
                _context.SaveChanges();

                return _mapper.Map<TModel>(entity);
            }
            catch
            {
                throw;
            }
        }

        public virtual bool Delete(int id)
        {
            var entity =_context.Set<TDatabase>().Find(id);
            if (entity != null)
            {
                _context.Set<TDatabase>().Remove(entity);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
