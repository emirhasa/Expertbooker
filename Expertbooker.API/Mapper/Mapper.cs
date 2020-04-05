using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Projekt, Model.Projekt>();
            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<Model.Kategorija, Database.Kategorija>();
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Uloga, Model.Uloga>();
            CreateMap<Database.KorisnikUloga, Model.KorisnikUloga>();
            CreateMap<Database.Stanje, Model.Stanje>();
            CreateMap<Database.ProjektDetalji, Model.ProjektDetalji>();
            CreateMap<Database.KorisnikSlika, Model.KorisnikSlika>();
            CreateMap<Database.Ekspert, Model.Ekspert>();
            CreateMap<Database.Poslodavac, Model.Poslodavac>();
            CreateMap<Database.RecenzijaOEkspert, Model.RecenzijaOEkspert>();
            CreateMap<Database.RecenzijaOPoslodavac, Model.RecenzijaOPoslodavac>();
            CreateMap<Database.NotifikacijaEkspert, Model.NotifikacijaEkspert>();
            CreateMap<Database.NotifikacijaPoslodavac, Model.NotifikacijaPoslodavac>();
            //CreateMap<Database.KorisnikKategorija, Model.KorisnikKategorija>();
            CreateMap<Database.Ponuda, Model.Ponuda>();
            CreateMap<Database.EkspertKategorijaPretplata, Model.EkspertKategorijaPretplata>();
            CreateMap<Model.ProjektDetalji, Database.ProjektDetalji>();
            CreateMap<Database.ProjektDetaljiPrilog, Model.ProjektDetaljiPrilog>();

            //insert update requests
            CreateMap<Model.ProjektUpsertRequest, Database.Projekt>();
            CreateMap<Model.Requests.KategorijaUpsertRequest, Database.Kategorija>();
            CreateMap<Model.Requests.KorisnikUpsertRequest, Database.Korisnik>();
            CreateMap<Model.Requests.ProjektDetaljiUpsertRequest, Database.ProjektDetalji>();
            CreateMap<Model.Requests.ProjektDetaljiPrilogUpsertRequest, Database.ProjektDetaljiPrilog>();
            CreateMap<Model.Requests.KorisnikSlikaUpsertRequest, Database.KorisnikSlika>();
            CreateMap<Model.Requests.EkspertUpsertRequest, Database.Ekspert>();
            CreateMap<Model.Requests.PoslodavacUpsertRequest, Database.Poslodavac>();
            CreateMap<Model.Requests.RecenzijaOEkspertUpsertRequest, Database.RecenzijaOEkspert>();
            CreateMap<Model.Requests.RecenzijaOPoslodavacUpsertRequest, Database.RecenzijaOPoslodavac>();
            CreateMap<Model.Requests.PonudaUpsertRequest, Database.Ponuda>();
            CreateMap<Model.Requests.NotifikacijaEkspertUpsertRequest, Database.NotifikacijaEkspert>();

        }
    }
}
