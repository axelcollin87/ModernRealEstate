namespace ModernRealEstate.Estates.Residential;

public class Apartment : Residential
{
    public int FloorNumber { get; set; }
    public int ApartmentNumber { get; set; }

    public Apartment(Address EstateAddress, String Category, String LegalForm, int SquareFootage, int NumberOfBedrooms, int NumberOfBathrooms, int FloorNumber, int ApartmentNUmber)
        : base (EstateAddress, Category, LegalForm, SquareFootage, NumberOfBedrooms, NumberOfBathrooms)
    {
        this.FloorNumber = FloorNumber;
        this.ApartmentNumber = ApartmentNUmber;
    }

    public override string CreateDescription()
    {
        return $"This is a Apartment with a square footage of {SquareFootage} m2, {NumberOfBedrooms} bedrooms, {NumberOfBathrooms} bathrooms and is located on floor {FloorNumber}";

    }
}