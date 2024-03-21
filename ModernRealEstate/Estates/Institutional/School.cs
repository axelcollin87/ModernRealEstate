namespace ModernRealEstate.Estates.Institutional;

public class School : Institutional
{
    public String SchoolName { set; get; }
    public String SchoolType { set; get; }

    public School(Address EstateAddress, String Category, String LegalForm, Boolean IsCommunal, String SchoolName, String SchoolType)
        : base(EstateAddress, Category, LegalForm, IsCommunal)
    {
        this.SchoolName = SchoolName;
        this.SchoolType = SchoolType;
    }

    public School(Address EstateAddress)
        : base(EstateAddress)
    {

    }

    public override string CreateDescription()
    {
        string description = $"The {SchoolName} school is a {SchoolType}";

        if (IsCommunal)
        {
            description += "and it is communaly driven";
        }

        return description;
    }

}