using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using VerivoxTariffComparison.Services;

namespace AdeccoAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ElectricityController : ControllerBase {

        private readonly IElectricityService _service;

        public ElectricityController(IElectricityService service) {
            _service = service;
        }

        [HttpGet("{consumption}")]
        public IActionResult GetAll(int consumption) {
            if (consumption <= 0)
                return UnprocessableEntity();


            var result = _service.GetAll(consumption);
            return new JsonResult(result);
        }

    }
}
