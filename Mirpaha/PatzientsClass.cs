namespace Mirpaha
{
    public class PatzientsClass
    {
        private int Id;
        private String Health_insurance;
        private String PhoneNumber;
        private String Address;
        public int id { get; set; }
        public String health_insurance { get; set; }
        public String phoneNumber { get; set; }
        public String address { get; set; }
        public PatzientsClass(int id, String health_insurance, String phoneNumber, String address)
        {
            this.Id = id;
            this.health_insurance = health_insurance;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }
    }
}
