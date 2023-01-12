using System.Text.Json.Serialization;

namespace powerplant_coding_challenge.DTO
{
    public class PowerplantDTO
    {
        public PowerplantDTO(string name, double generatedPower) 
        {
            Name = name;
            GeneratedPower = generatedPower;
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("p")]
        public double GeneratedPower { get; set; }
    }
}
