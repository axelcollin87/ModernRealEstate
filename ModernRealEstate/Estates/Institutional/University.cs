namespace ModernRealEstate.Estates.Institutional;

public class University : Institutional
{
    public int StudentCapacity { get; set; }

    public University(Address EstateAddress, String Category, String LegalForm, Boolean IsCommunal, int StudentCapacity)
        : base(EstateAddress, Category, LegalForm, IsCommunal)
    {
        this.StudentCapacity = StudentCapacity;
    }

    public override string CreateDescription()
    {
        string description = $"The university has a student capacity of {StudentCapacity} students";

        if (IsCommunal)
        {
            description += "and it is communaly driven";
        }

        return description;
    }
}