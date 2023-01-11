namespace powerplant_coding_challenge.Model
{
    public class Payload
    {
        public int Load { get; set; }
        public Fuels Fuels { get; set; }
        public List<Powerplant> Powerplants { get; set; } 
    }
}
