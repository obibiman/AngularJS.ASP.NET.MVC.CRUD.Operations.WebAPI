using System.Collections.Generic;
using System.Linq;
using AngularJS.Entity.DataMart.DataContext;
using AngularJS.Entity.Domain;

namespace AngularJS.Entity.DataMart.DataSeeding
{
    public class CountryBuilder
    {
        public List<Country> BuildCountry(AngularContext context)
        {
            var countries = new List<Country>
            {
                new Country
                {
                    CountryCode = "IN",
                    CountryName = "India",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'IN';")
                            .FirstOrDefault()
                },
                new Country
                {
                    CountryCode = "CA",
                    CountryName = "Australia",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'CA';")
                            .FirstOrDefault()
                },
                new Country
                {
                    CountryCode = "UK",
                    CountryName = "United Kingdom",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'UK';")
                            .FirstOrDefault()
                },
                new Country
                {
                    CountryCode = "USA",
                    CountryName = "United States",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
            };

            return countries;
        } 
    }
}