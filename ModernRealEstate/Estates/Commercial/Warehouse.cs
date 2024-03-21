
namespace ModernRealEstate.Estates.Commercial
{
    internal class Warehouse : Commercial
    {
        public int CeilingHeight { get; set; }
        public Boolean HasLoadingDock { get; set; }

        public Warehouse(Address EstateAddress, String Category, String LegalForm, String PropertyName, int CeilingHeight, Boolean HasLoadingDock)
            : base(EstateAddress, Category, LegalForm, PropertyName)
        {
            this.CeilingHeight = CeilingHeight;
            this.HasLoadingDock = HasLoadingDock;
        }

        public Warehouse(Address EstateAddress) 
            : base(EstateAddress)
        {

        }

        public override string CreateDescription()
        {
            String description = $"This warehouse {PropertyName} has a ceiling height of {CeilingHeight} m";

            if (HasLoadingDock)
            {
                description += " and has a loading dock";
            }

            return description;
        }
    }
}
