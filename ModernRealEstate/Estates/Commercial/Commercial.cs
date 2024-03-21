namespace ModernRealEstate.Estates.Commercial;

public abstract class Commercial : Estate
{
    public String PropertyName { get; set; }

    public Commercial(Address EstateAddress, String Category, String LegalForm, String PropertyName) 
        : base(EstateAddress, Category, LegalForm)
    {
        this.PropertyName = PropertyName;
    }

    public Commercial(Address EstateAddress)
        : base(EstateAddress)
    {

    }
}