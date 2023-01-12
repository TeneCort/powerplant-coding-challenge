using Microsoft.AspNetCore.Mvc;
using powerplant_coding_challenge.Model;
using System.Text.Json;

namespace powerplant_coding_challenge.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductionPlanController : ControllerBase
    {
        [HttpPost(Name = "productionplan")]
        public IActionResult GenerateProductionPlan(Payload payload)
        {
            return Ok("Endpoint working");
        }
    }
}
