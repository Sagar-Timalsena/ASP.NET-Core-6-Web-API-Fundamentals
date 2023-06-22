using CityInfo.Models;
using System.Xml.Linq;

namespace CityInfo
{
    public class CityDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CityDataStore Current { get; } = new CityDataStore();


        public CityDataStore()
        {
            Cities = new List<CityDto>()
                {
                new CityDto()
                {
                    Id = 1,
                    Name = "Kathmandu",
                    Description="City Of Polution"
                },
                  new CityDto()
{
    Id = 2,
    Name = "New York",
    Description = "The Big Apple"
},
new CityDto()
{
    Id = 3,
    Name = "Tokyo",
    Description = "Capital of Japan"
},
new CityDto()
{
    Id = 4,
    Name = "Paris",
    Description = "City of Love"
},
new CityDto()
{
    Id = 5,
    Name = "London",
    Description = "Historic City"
},
new CityDto()
{
    Id = 6,
    Name = "Sydney",
    Description = "Harbor City"
},
new CityDto()
{
    Id = 7,
    Name = "Rio de Janeiro",
    Description = "Marvellous City"
},
new CityDto()
{
    Id = 8,
    Name = "Cairo",
    Description = "City of Pyramids"
},
new CityDto()
{
    Id = 9,
    Name = "Moscow",
    Description = "Capital of Russia"
},
new CityDto()
{
    Id = 10,
    Name = "Dubai",
    Description = "City of Skyscrapers"
},
new CityDto()
{
    Id = 11,
    Name = "Rome",
    Description = "Eternal City"
},
new CityDto()
{
    Id = 12,
    Name = "Berlin",
    Description = "Capital of Germany"
},
new CityDto()
{
    Id = 13,
    Name = "Singapore",
    Description = "Garden City"
},
new CityDto()
{
    Id = 14,
    Name = "Toronto",
    Description = "Multicultural City"
},
new CityDto()
{
    Id = 15,
    Name = "Mumbai",
    Description = "City of Dreams"
},
new CityDto()
{
    Id = 16,
    Name = "Istanbul",
    Description = "City on Two Continents"
}

            };
        }


    }
}
