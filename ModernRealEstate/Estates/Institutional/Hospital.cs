
namespace ModernRealEstate.Estates.Institutional
{
    internal class Hospital : Institutional
    {
        public String HospitalName { get; set; }
        public Boolean HasEmergencyRoom { get; set; }

        public Hospital(Address EstateAddress, String Category, String LegalForm, Boolean IsCommunal, String HospitalName, Boolean HasEmergencyRoom)
            : base(EstateAddress, Category, LegalForm, IsCommunal)
        {
            this.HospitalName = HospitalName;
            this.HasEmergencyRoom = HasEmergencyRoom;
        }

        public Hospital(Address EstateAddress)
            : base(EstateAddress) 
        {

        }

        public override string CreateDescription()
        {
            string description = $"This is the {HospitalName} hospital";

            if (IsCommunal)
            {
                description += "and it is communaly driven";
            }

            if (HasEmergencyRoom)
            {
                description += "and it has a emergency room";
            }
            return description;
        }
    }
}
