using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace powerplant_coding_challenge.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductionPlanController : ControllerBase
    {
        [HttpPost(Name = "productionplan")]
        public IActionResult GenerateProductionPlan()
        {
            return Ok("Endpoint working");
        }
    }
}
