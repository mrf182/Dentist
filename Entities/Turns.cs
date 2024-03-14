namespace dentistClinic.Entities
{
    public class Turns
    {
        public string Turnid { get; set; }
        public string doctor { get; set; }
        public string time {  get; set; }
        public int TurnLength { get; set; }


        public Turns()
        {
            Turnid = "";
            doctor = "";
            time = string.Empty;
            TurnLength = 0;
    }
    }

    
}
