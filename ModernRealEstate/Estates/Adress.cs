using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace ModernRealEstate.Estates;

public class Address
{
    public String Street { set; get; }
    public String City { set; get; }
    public String ZipCode { set; get; }
    public String Country { set; get; }

    public Address(string street, string zipCode, string city, String country)
    {
        Street = street;
        ZipCode = zipCode;
        City = city;
        Country = country;
    }

}