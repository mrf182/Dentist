namespace dentistClinic.Entities
{
    public class Clients
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string stutus {  get; set; }
        public string Insurance { get; set; }


        public Clients() {
            ClientId = "";
            ClientName = string.Empty;
            stutus = string.Empty;
            Insurance = string.Empty;

        }
        public Clients( string ClientId,string ClientName,string stutus,string Insurance)
        {
            this.ClientId = ClientId;
            this.ClientName = ClientName;
            this.stutus = stutus;
            this.Insurance = Insurance;

        }


    }
}
