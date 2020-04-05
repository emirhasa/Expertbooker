using AutoMapper;
using EkspertBooker.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.WebAPI.Service
{
    public class StanjaService : IStanjaService
    {
        private IMapper _mapper;
        private EkspertBookerContext _context;
        public StanjaService(EkspertBookerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Stanje GetById(string stanjeId)
        {
            var entity = _context.Stanja.Find(stanjeId);
            return _mapper.Map<Model.Stanje>(entity);
        }

        public List<Model.Stanje> Get()
        {
            return _mapper.Map<List<Model.Stanje>>(_context.Stanja.ToList());
        }
    }
}
