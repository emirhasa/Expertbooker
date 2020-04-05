using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkspertBooker.WebAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EkspertBooker.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StanjaController : ControllerBase
    {
        IStanjaService _service;
        public StanjaController(IStanjaService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Stanje>> Get()
        {
            var result = _service.Get();
            if(result != null)
            {
                if(result.Count > 0)
                {
                    return result;
                } return NoContent();
            } return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Stanje> GetById(string id)
        {
            return _service.GetById(id);
        }
    }
}