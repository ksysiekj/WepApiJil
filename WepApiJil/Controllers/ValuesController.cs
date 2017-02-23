﻿using System.Web.Http;
using WepApiJil.Services;

namespace WepApiJil.Controllers
{
    public sealed class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(ValueServices.Values);
        }
    }
}
