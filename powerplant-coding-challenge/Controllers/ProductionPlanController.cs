using Microsoft.AspNetCore.Mvc;
using powerplant_coding_challenge.DTO;
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

            var PowerPlantListDTO = new List<PowerplantDTO>();

            // Can use automapper
            foreach(var powerplant in orderedPowerPlantList)
            {
                PowerPlantListDTO.Add(new PowerplantDTO(powerplant.Name, powerplant.GeneratedPower););
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string response = JsonSerializer.Serialize(PowerPlantListDTO, options);

            return Ok(response);
        }
    }
}
