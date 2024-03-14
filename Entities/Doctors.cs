namespace dentistClinic.Entities
{
    public class Doctors
    {
        public string DoctorId {  get; set; }
        public string DoctorName { get; set; }
        public string DoctorStutus { get; set;}
        public int  DoctorAge { get; set;}


        public Doctors()
        {
            DoctorId = string.Empty;
            DoctorName = string.Empty;
            DoctorStutus = string.Empty;
            DoctorAge = 0;
        }
    }
}
