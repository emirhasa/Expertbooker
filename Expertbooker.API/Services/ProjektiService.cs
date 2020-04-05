using AutoMapper;
using EkspertBooker.WebAPI.Database;
using EkspertBooker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EkspertBooker.WebAPI.Service
{
    public class ProjektiService : BaseCRUDService<Model.Projekt, ProjektiSearchRequest, ProjektUpsertRequest, ProjektUpsertRequest, Database.Projekt>
    {
        public ProjektiService(EkspertBookerContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Projekt> Get(ProjektiSearchRequest request)
        {
            var query = _context.Projekti.AsQueryable();

            if(request.KategorijaId > 0)
            {
                query = query.Where(p => p.KategorijaId == request.KategorijaId);
            }

            if(!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(p => p.Naziv.Contains(request.Naziv));
            }

            if(!string.IsNullOrWhiteSpace(request?.StanjeId))
            {
                query = query.Where(p=>p.StanjeId == request.StanjeId);
            }

            if(request.Hitan != null)
            {
                query = query.Where(p => p.Hitan == request.Hitan);
            }

            if(request.PoslodavacId != null)
            {
                query = query.Where(p => p.PoslodavacId == request.PoslodavacId);
            }

            if(request.EkspertId != null)
            {
                query = query.Where(p => p.EkspertId == request.EkspertId);
            }

            var result = query.Include(p=>p.Kategorija).Include(p=>p.ProjektDetalji).Include(p=>p.Poslodavac).ThenInclude(p=>p.Korisnik).ToList();
            return _mapper.Map<List<Model.Projekt>>(result);
        }

        public override Model.Projekt GetById(int id)
        {
            var entity = _mapper.Map<Model.Projekt>(_context.Projekti.Include(p => p.ProjektDetalji).Include(p=>p.RecenzijaOEkspert).Include(p=>p.RecenzijaOPoslodavac).Include(p=>p.Kategorija)
                .Include(p => p.Poslodavac).ThenInclude(p=>p.Korisnik).Include(p=>p.Ekspert).ThenInclude(e=>e.Korisnik)
                .Where(p=>p.ProjektId == id).SingleOrDefault());
            return entity;
        }

        public override Model.Projekt Insert(ProjektUpsertRequest projekt)
        {
            var novi_projekt = base.Insert(projekt);
            try
            {
                var eksperti_obavijesti = _context.EkspertiKategorijePretplate.Where(e => e.KategorijaId == projekt.KategorijaId).Include(e => e.Ekspert).ToList();
                foreach (Database.EkspertKategorijaPretplata pretplata in eksperti_obavijesti)
                {
                    if (pretplata.Ekspert.Notifikacije == true)
                    {
                        _context.NotifikacijeEksperti.Add(new Database.NotifikacijaEkspert
                        {
                            EkspertId = pretplata.EkspertId,
                            Poruka = "Objavljen je novi projekat u kategoriji na koju ste se pretplatili, ime projekta: " + projekt.Naziv,
                            ProjektId = novi_projekt.ProjektId,
                            Vrijeme = DateTime.Now
                        });
                    }
                }
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
            return novi_projekt;
        }

        public override Model.Projekt Update(int id, ProjektUpsertRequest projekt)
        {
            if(projekt.StanjeId == "Zavrsen")
            {
                projekt.DatumZavrsetka = DateTime.Now;
                Database.Projekt db_projekt = _context.Projekti.Find(id);
                Database.Ekspert ekspert = _context.Eksperti.Where(e=>e.KorisnikId == db_projekt.EkspertId).SingleOrDefault();
                Database.Poslodavac poslodavac = _context.Poslodavci.Where(e=>e.KorisnikId == db_projekt.PoslodavacId).SingleOrDefault();
                ekspert.BrojZavrsenihProjekata++;
                poslodavac.BrojZavrsenihProjekata++;
                _context.SaveChanges();
            }
            return base.Update(id, projekt);
        }
    }
}
