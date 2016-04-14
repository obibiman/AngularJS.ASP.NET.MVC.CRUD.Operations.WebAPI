using System.Collections.Generic;
using System.Linq;
using AngularJS.Entity.DataMart.DataContext;
using AngularJS.Entity.Domain;

namespace AngularJS.Entity.DataMart.DataSeeding
{
    public class StateBuilder
    {
        public List<State> BuildStates(AngularContext context)
        {
            var states = new List<State>
            {
                //India
                new State
                {
                    StateCode = "MP",
                    StateName = "Madhya Pradesh",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'IN';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "MH",
                    StateName = "Maharashtra",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'IN';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "DL",
                    StateName = "Delhi",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'IN';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "KN",
                    StateName = "Kanpur",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'IN';")
                            .FirstOrDefault()
                },
//United Kingdom
                new State
                {
                    StateCode = "LN",
                    StateName = "London",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'UK';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "LP",
                    StateName = "Liverpool",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'UK';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "MC",
                    StateName = "Manchester",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'UK';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "LD",
                    StateName = "Leeds",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'UK';")
                            .FirstOrDefault()
                },
//Australia
                new State
                {
                    StateCode = "SD",
                    StateName = "Sydney",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'CA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "MB",
                    StateName = "Melbourne",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'CA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "BR",
                    StateName = "Brisbane",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'CA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "PE",
                    StateName = "Perth",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'CA';")
                            .FirstOrDefault()
                },
//USA
                new State
                {
                    StateCode = "MN",
                    StateName = "Minnesota",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "MI",
                    StateName = "Michigan",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "ME",
                    StateName = "Maine",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "AR",
                    StateName = "Arkansas",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "VA",
                    StateName = "Virginia",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "AZ",
                    StateName = "Arizona",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "NV",
                    StateName = "Nevada",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "NM",
                    StateName = "New Mexico",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "CA",
                    StateName = "California",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "ID",
                    StateName = "Idaho",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "MA",
                    StateName = "Massachusetts",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "GA",
                    StateName = "Georgia",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "OK",
                    StateName = "Oklahoma",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "WV",
                    StateName = "West Virginia",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "MO",
                    StateName = "Missouri",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "NY",
                    StateName = "New York",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "TN",
                    StateName = "Tennessee",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "MD",
                    StateName = "Maryland",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
                new State
                {
                    StateCode = "TX",
                    StateName = "Texas",
                    CountryId =
                        context.Database.SqlQuery<int>("SELECT CountryId FROM dbo.Country WHERE CountryCode = 'USA';")
                            .FirstOrDefault()
                },
            };

            return states;
        }
    }
}