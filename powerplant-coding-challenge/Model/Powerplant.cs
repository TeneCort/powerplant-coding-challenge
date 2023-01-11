namespace powerplant_coding_challenge.Model
{
    public class Powerplant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        //TODO change to enum
        public decimal Efficiency { get; set; }
        public int Pmin { get; set; }
        public int Pmax { get; set; }

        // TODO Cost calculation
    }
}
