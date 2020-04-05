using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EkspertBooker.WebAPI.Database;
using EkspertBooker.Model;
using EkspertBooker.Model.Requests;
using EkspertBooker.WebAPI.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using EkspertBooker.WebAPI.Filters;
using EkspertBooker.WebAPI.Security;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.Authentication;

namespace EkspertBooker.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
#if DEBUG
            string connection = @"Server=.;Database=EkspertBooker;Trusted_Connection=true;";
#endif
#if RELEASE
            string connection = @"Server=--;Database=--;PersistSecurityInfo=False;User=--;Password=--;MultipleActiveResultSets=False;";
#endif
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<EkspertBookerContext>(options => options.UseSqlServer(connection));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "EkspertBooker API", Version = "v0.65" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            services.AddAuthentication("BasicAuthentication").
            AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IBaseCRUDService<Model.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest>, KategorijeService>();
            services.AddScoped<IBaseCRUDService<Model.Projekt, ProjektiSearchRequest, ProjektUpsertRequest, ProjektUpsertRequest>, ProjektiService>();
            //services.AddScoped<IBaseCRUDService<Model.Korisnik, KorisniciSearchRequest, KorisnikUpsertRequest, KorisnikUpsertRequest>, KorisniciService>();
            services.AddScoped<IBaseCRUDService<Model.ProjektDetalji, ProjektDetaljiSearchRequest, ProjektDetaljiUpsertRequest, ProjektDetaljiUpsertRequest>, ProjektDetaljiService>();
            services.AddScoped<IBaseCRUDService<Model.Ekspert, EkspertiSearchRequest, EkspertUpsertRequest, EkspertUpsertRequest>, EkspertiService>();
            services.AddScoped<IBaseCRUDService<Model.Poslodavac, PoslodavciSearchRequest, PoslodavacUpsertRequest, PoslodavacUpsertRequest>, PoslodavciService>();
            services.AddScoped<IBaseCRUDService<Model.ProjektDetaljiPrilog, object, ProjektDetaljiPrilogUpsertRequest, ProjektDetaljiPrilogUpsertRequest>, BaseCRUDService<Model.ProjektDetaljiPrilog, object, ProjektDetaljiPrilogUpsertRequest, ProjektDetaljiPrilogUpsertRequest, Database.ProjektDetaljiPrilog>>();
            services.AddScoped<IBaseCRUDService<Model.KorisnikSlika, object, KorisnikSlikaUpsertRequest, KorisnikSlikaUpsertRequest>, BaseCRUDService<Model.KorisnikSlika, object, KorisnikSlikaUpsertRequest, KorisnikSlikaUpsertRequest, Database.KorisnikSlika>>();
            services.AddScoped<IBaseCRUDService<Model.RecenzijaOEkspert, RecenzijeOEkspertiSearchRequest, RecenzijaOEkspertUpsertRequest, RecenzijaOEkspertUpsertRequest>, RecenzijeOEkspertiService>();
            services.AddScoped<IBaseCRUDService<Model.RecenzijaOPoslodavac, RecenzijeOPoslodavciSearchRequest, RecenzijaOPoslodavacUpsertRequest, RecenzijaOPoslodavacUpsertRequest>, RecenzijeOPoslodavciService>();
            services.AddScoped<IBaseCRUDService<Model.RecenzijaOEkspert, RecenzijeOEkspertiSearchRequest, RecenzijaOEkspertUpsertRequest, RecenzijaOEkspertUpsertRequest>, RecenzijeOEkspertiService>();
            services.AddScoped<IBaseCRUDService<Model.Ponuda, PonudeSearchRequest, PonudaUpsertRequest, PonudaUpsertRequest>, PonudeService>();

            services.AddScoped<IStanjaService, StanjaService>();
            services.AddScoped<IBaseGetService<Model.Uloga, object>, BaseGetService<Model.Uloga, object, Database.Uloga>>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IEkspertiKategorijePretplateService, EkspertiKategorijePretplateService>();
            //services.AddScoped<IKorisniciKategorijeService, KorisniciKategorijeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            //app.UseMvc();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    //template: "{controller=Index}/{action=Home}/{id?}");
                    template: "{controller=Index}/{action=Home}");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "EkspertBooker API v0.65");
            });
        }
    }
}
