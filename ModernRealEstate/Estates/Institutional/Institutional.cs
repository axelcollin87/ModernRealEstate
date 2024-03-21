namespace ModernRealEstate.Estates.Institutional;

public abstract class Institutional : Estate
{
    public Boolean IsCommunal { get; set; }

    public Institutional(Address EstateAddress, String Category, String LegalForm, Boolean IsCommunal) 
        : base(EstateAddress, Category, LegalForm)
    {
        this.IsCommunal = IsCommunal;
    }

    public Institutional(Address EstateAddress)
        : base(EstateAddress)
    {

    }
}