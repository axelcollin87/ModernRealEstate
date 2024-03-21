namespace ModernRealEstate.Estates;

public interface IEstate
{
    int Id { get; set; }
    Address EstateAddress { get; set; }

}