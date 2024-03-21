namespace ModernRealEstate.Estates.Residential;

public class Townhouse : Residential
{
    public int NumberOfFloors { get; set; }
    public int CommonAreaFee { get; set; }


    public Townhouse(Address EstateAddress, String Category, String LegalForm, int SquareFootage, int NumberOfBedrooms, int NumberOfBathrooms, int NumberOfFloors, int CommonAreaFee)
        : base(EstateAddress, Category, LegalForm, SquareFootage, NumberOfBedrooms, NumberOfBathrooms)
    {
        this.NumberOfFloors = NumberOfFloors;
        this.CommonAreaFee = CommonAreaFee;
    }

    public override string CreateDescription()
    {
        return $"This is a Townhouse with a square footage of {SquareFootage} m2, {NumberOfBedrooms} bedrooms, {NumberOfBathrooms} bathrooms, has {NumberOfFloors} floors and a common area fee of {CommonAreaFee}"; 

    }
}