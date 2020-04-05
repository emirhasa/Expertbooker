using AutoMapper;
using EkspertBooker.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.WebAPI.Service
{
    public class BaseGetService<TModel, TSearch, TDatabase> : IBaseGetService<TModel, TSearch> where TDatabase: class
    {
        protected readonly EkspertBookerContext _context;
        protected readonly IMapper _mapper;
        public BaseGetService(EkspertBookerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(TSearch search)
        {
            return  _mapper.Map<List<TModel>>(_context.Set<TDatabase>().ToList());
        }

        public virtual TModel GetById(int id)
        {
            var item = _mapper.Map<TModel>(_context.Set<TDatabase>().Find(id));
            return item;
        }
    }
}
