using Microsoft.AspNetCore.Mvc;
using VerivoxTariffComparison.Services;

namespace VerivoxTariffComparison.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ElectricityController : ControllerBase {

        private readonly IElectricityService _service;

        public ElectricityController(IElectricityService service) {
            _service = service;
        }

        /// <summary>
        /// Get Electricity Tariffs by Consumption
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET api/Electricity/{consumption}
        ///
        /// </remarks>
        /// <param name="consumption">Consumption (kWh/year)</param>
        /// <returns>List of products sorted by costs in ascending order</returns>
        /// <response code="400">If the consumption less than 1(kWh/year)</response> 
        [HttpGet("{consumption}")]
        public IActionResult GetAll(int consumption) {
            if (consumption <= 0)
                return BadRequest();

            var result = _service.GetAll(consumption);
            return new JsonResult(result);
        }

    }
}
