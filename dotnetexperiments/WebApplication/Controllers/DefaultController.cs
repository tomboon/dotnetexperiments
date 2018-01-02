using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("api/default")]
        public IHttpActionResult Default()
        {
            return Ok("default");

        }
    }
}
