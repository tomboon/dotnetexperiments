using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using dotnetexperiments;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class KwartaalController : ApiController
    {
        private readonly KwartaalService _service;

        public KwartaalController(KwartaalService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("api/kwartaal/huidig")]
        public IHttpActionResult Huidig()
        {
            return Ok(_service.Huidig());
        }
    }
}