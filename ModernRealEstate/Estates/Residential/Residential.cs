namespace ModernRealEstate.Estates.Residential;

public abstract class Residential : Estate
{
    public int SquareFootage { get; set; }
    public int NumberOfBedrooms { get; set; }
    public int NumberOfBathrooms { get; set; }

    public Residential(Address EstateAddress, String Category, String LegalForm, int SquareFootage, int NumberOfBedrooms, int NumberOfBathrooms) 
        : base(EstateAddress, Category, LegalForm)
    {
        this.SquareFootage = SquareFootage;
        this.NumberOfBedrooms = NumberOfBedrooms;
        this.NumberOfBathrooms = NumberOfBathrooms;
    }

}