using AutoMapper;
using EkspertBooker.Model.Requests;
using EkspertBooker.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.WebAPI.Service
{
    public class RecenzijeOEkspertiService : BaseCRUDService<Model.RecenzijaOEkspert, RecenzijeOEkspertiSearchRequest, RecenzijaOEkspertUpsertRequest, RecenzijaOEkspertUpsertRequest, Database.RecenzijaOEkspert>
    {
        public RecenzijeOEkspertiService(EkspertBookerContext context, IMapper mapper):base(context, mapper)
        {
        }

        public override List<Model.RecenzijaOEkspert> Get(RecenzijeOEkspertiSearchRequest search)
        {
            if(search.EkspertId.HasValue) 
            {
                return _mapper.Map<List<Model.RecenzijaOEkspert>>(_context.RecenzijeOEksperti.Where(roe=>roe.EkspertId == search.EkspertId).ToList());
            } else
            {
                return _mapper.Map<List<Model.RecenzijaOEkspert>>(_context.RecenzijeOEksperti.Include(roe=>roe.Ekspert).Include(roe=>roe.Poslodavac).ToList());
            }
        }

        public override Model.RecenzijaOEkspert Insert(RecenzijaOEkspertUpsertRequest request)
        {
            request.Vrijeme = DateTime.Now;
            try
            {
                var result = base.Insert(request);
                //update info o ekspertu, ponovo izracunati prosjecnu ocjenu
                var ekspert = _context.Eksperti.Find(result.EkspertId);

                if(ekspert.BrojRecenzija > 0)
                {
                    ekspert.ProsjecnaOcjena = ((ekspert.ProsjecnaOcjena * ekspert.BrojRecenzija) + request.Ocjena) / (ekspert.BrojRecenzija + 1);
                } else
                {
                    ekspert.ProsjecnaOcjena = request.Ocjena;
                }
                ekspert.BrojRecenzija++;
                _context.SaveChanges();
                return result;
            } 
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public override bool Delete(int id)
        {
            return base.Delete(id);
        }

    }
}
