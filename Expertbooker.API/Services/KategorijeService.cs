using AutoMapper;
using EkspertBooker.Model.Requests;
using EkspertBooker.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.WebAPI.Service
{
    public class KategorijeService : BaseCRUDService<Model.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest, Database.Kategorija>
    {
        public KategorijeService(EkspertBookerContext context, IMapper mapper): base(context, mapper)
        {

        }

        public override List<Model.Kategorija> Get(object search)
        {
            return _mapper.Map<List<Model.Kategorija>>(base._context.Kategorije.OrderBy(k=>k.Naziv).ToList());
        }
    }
}
