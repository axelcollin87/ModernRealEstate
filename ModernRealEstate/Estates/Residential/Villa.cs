namespace ModernRealEstate.Estates.Residential;

public class Villa : Residential
{
    public int GardenArea { set; get; }
    public Boolean HasGarage { set; get; }


    public Villa(Address EstateAddress, String Category, String LegalForm, int SquareFootage, int NumberOfBedrooms, int NumberOfBathrooms, int GardenArea, Boolean HasGarage)
        : base(EstateAddress, Category, LegalForm, SquareFootage, NumberOfBedrooms, NumberOfBathrooms)
    {
        this.GardenArea = GardenArea;
        this.HasGarage = HasGarage;
    }

    public override string CreateDescription()
    {
        string description = $"This is a Villa with a square footage of {SquareFootage} m2, {NumberOfBedrooms} bedrooms, {NumberOfBathrooms} bathrooms, a garden area of {GardenArea} m2";

        if (HasGarage)
        {
            description += " and a garage";
        }

        return description;
    }
}