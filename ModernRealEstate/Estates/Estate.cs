using ModernRealEstate.Generics;

namespace ModernRealEstate.Estates;

public abstract class Estate : IEstate
{
    public int Id { get; set; }
    public Address EstateAddress { get; set; }
    public String Category { get; set; }
    public String LegalForm { get; set; }

    public abstract string CreateDescription();

    private static int PreviousId = 0;

    public Estate(Address EstateAddress, String category, String LegalForm)
    {
        this.EstateAddress = EstateAddress;
        this.Category = category;
        this.LegalForm = LegalForm;
        Id = ++PreviousId;
    }
    public Estate(Address EstateAddress)
    {
        Id = ++PreviousId;
        this.EstateAddress = EstateAddress;
    }

}