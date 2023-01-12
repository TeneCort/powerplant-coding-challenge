using Microsoft.AspNetCore.Mvc;
using powerplant_coding_challenge.Logic;
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
            Tools.GetTotalWindPower(payload.Powerplants, payload.Load, payload.Fuels.Wind);

            Tools.SetMWhCost(payload.Powerplants, payload.Fuels);

            var orderedPowerPlantList = payload.Powerplants.OrderBy(i => i.CostPerMWh);

            Tools.AffectLoadNeeded(orderedPowerPlantList, payload.Load);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(orderedPowerPlantList, options);

            return Ok(jsonString);
        }
    }
}
