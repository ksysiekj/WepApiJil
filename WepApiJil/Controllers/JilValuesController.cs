using System.Web.Http;
using WepApiJil.Attributes;
using WepApiJil.Services;

namespace WepApiJil.Controllers
{
    [JilSerialization]
    public sealed class JilValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(ValueServices.Values);
        }
    }
}