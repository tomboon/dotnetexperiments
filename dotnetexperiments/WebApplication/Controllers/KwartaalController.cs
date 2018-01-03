using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dotnetexperiments;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class KwartaalController : ApiController
    {
        private readonly IKwartaalService _service;

        public KwartaalController(IKwartaalService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("api/kwartaal/huidig")]
        public IHttpActionResult HuidigKwartaal()
        {
            return Ok(_service.GetHuidigKwartaal());
        }

        [HttpGet]
        [Route("api/kwartalen/{jaar}")]
        public IEnumerable<Kwartaal> Kwartalen(int jaar)
        {
            return _service.KwartalenVoorJaar(jaar);
        }

        [HttpPost]
        [Route("api/kwartaal/huidig")]
        public IHttpActionResult IsHuidigKwartaal([FromBody] Kwartaal kwartaal)
        {
            if (_service.IsHuidigKwartaal(kwartaal)) return Ok();
            return BadRequest();
        }
    }
}
