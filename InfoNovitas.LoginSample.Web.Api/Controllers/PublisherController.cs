using InfoNovitas.LoginSample.Services;
using InfoNovitas.LoginSample.Web.Api.Mapping;
using System.Web.Http;

namespace InfoNovitas.LoginSample.Web.Api.Controllers
{
    [Authorize]
    public class PublisherController : ApiController
    {
        private IPublisherService _service;

        public PublisherController(IPublisherService service)
        {
            _service = service;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var response = _service.GetPublishers();
            if (response.Success)
            {
                return Ok(response.Publishers.MapToViewModels());
            }
            else
            {
                return BadRequest("Greška kod dohvaćanja nakladnika");
            }
        }
    }
}
