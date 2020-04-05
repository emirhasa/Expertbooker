using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkspertBooker.WebAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EkspertBooker.WebAPI.Controllers
{
    public class UlogeController : BaseGetController<Model.Uloga, object>
    {
        public UlogeController(IBaseGetService<Model.Uloga, object> service) : base(service)
        {
        }
    }
}