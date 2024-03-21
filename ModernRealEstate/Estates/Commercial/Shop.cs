namespace ModernRealEstate.Estates.Commercial;

public class Shop : Commercial
{
    public int RetailSpace { get; set; }
    public int ParkingCapacity { get; set; }

    public Shop(Address EstateAddress, String Category, String LegalForm, String PropertyName, int RetailSpace, int ParkingCapacity)
        : base(EstateAddress, Category, LegalForm, PropertyName)
    {
        this.RetailSpace = RetailSpace;
        this.ParkingCapacity = ParkingCapacity;
    }

    public Shop(Address EstateAddress)
        : base(EstateAddress)
    {

    }

    public override string CreateDescription()
    {
        return $"This shop called {PropertyName} with retail space of about {RetailSpace} m2 and parking capacity for {ParkingCapacity} cars";
    }
}