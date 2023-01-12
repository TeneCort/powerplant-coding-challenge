using System.Text.Json.Serialization;

namespace powerplant_coding_challenge.Model
{
    public enum PowerplantType
    {
        Gasfired,
        Turbojet,
        Windturbine
    }
    public class Powerplant
    {
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PowerplantType Type { get; set; }
        public double Efficiency { get; set; }
        public int Pmin { get; set; }
        public int Pmax { get; set; }
        public double? CostPerMWh { get; set; }
        public double GeneratedPower { get; set; } = 0;
    }
}
