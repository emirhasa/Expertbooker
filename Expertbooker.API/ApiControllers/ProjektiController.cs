using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkspertBooker.Model;
using EkspertBooker.Model.Requests;
using EkspertBooker.WebAPI.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EkspertBooker.WebAPI.Controllers
{
    [Authorize]
    public class ProjektiController : BaseCRUDController<Model.Projekt, ProjektiSearchRequest, ProjektUpsertRequest, ProjektUpsertRequest>
    {
        public ProjektiController(IBaseCRUDService<Model.Projekt, ProjektiSearchRequest, ProjektUpsertRequest, ProjektUpsertRequest> service) : base(service)
        {
        }

        [Authorize(Roles = "Administrator, Poslodavac")]
        public override ActionResult<Model.Projekt> Insert(ProjektUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Administrator, Poslodavac")]
        public override ActionResult<Model.Projekt> Update(int id, ProjektUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize(Roles = "Administrator, Poslodavac")]
        public override ActionResult<bool> Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}