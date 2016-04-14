using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AngularJS.Entity.DataMart.DataContext;
using AngularJS.Entity.Domain;

namespace AngularJS.Entity.DataMart.DataSeeding
{
    public class DataContextInitializer : DropCreateDatabaseIfModelChanges<AngularContext>
    {
        protected override void Seed(AngularContext context)
        {
            //var countryBuilder = new CountryBuilder();
            //var countries = countryBuilder.BuildCountry(context);
            //countries.ForEach(m =>
            //{
            //    context.Countries.Add(m);
            //});
            //var stateBuilder = new StateBuilder();
            //var states = stateBuilder.BuildStates(context);
            //states.ForEach(m =>
            //{
            //    context.States.Add(m);
            //});

            var list = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Rohit",
                    LastName = "Mane",
                    Description = "Rohit Mane",
                    DateOfBirth = DateTime.Now.AddYears(-24),
                    Country = "IN",
                    State = "MH",
                    Salary = 3500.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Samuel",
                    LastName = "Crowder",
                    Description = "Musician",
                    DateOfBirth = DateTime.Now.AddYears(-19),
                    Country = "USA",
                    State = "TX",
                    Salary = 1900.00m,
                    IsActive = false
                },
                new Employee
                {
                    FirstName = "Jorge",
                    LastName = "DeJesus",
                    Description = "Accountant",
                    DateOfBirth = DateTime.Now.AddYears(-45),
                    Country = "USA",
                    State = "MD",
                    Salary = 5300.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Shankar",
                    LastName = "Kanase",
                    Description = "Rahul Singh",
                    DateOfBirth = DateTime.Now.AddYears(-23),
                    Country = "IN",
                    State = "MH",
                    Salary = 2300.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Brenda",
                    LastName = "DeMonaco",
                    Description = "Breanda of Everton",
                    DateOfBirth = DateTime.Now.AddYears(-34),
                    Country = "US",
                    State = "TN",
                    Salary = 3100.00m,
                    IsActive = true
                },    new Employee
                {
                    FirstName = "Brad",
                    LastName = "Poole",
                    Description = "Accountant",
                    DateOfBirth = DateTime.Now.AddYears(-45),
                    Country = "USA",
                    State = "NY",
                    Salary = 5300.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Marvin",
                    LastName = "Sutton",
                    Description = "Rahul Singh",
                    DateOfBirth = DateTime.Now.AddYears(-23),
                    Country = "IN",
                    State = "MH",
                    Salary = 2300.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Mary Jo",
                    LastName = "Alvarado",
                    Description = "Mary Jo",
                    DateOfBirth = DateTime.Now.AddYears(-34),
                    Country = "US",
                    State = "MO",
                    Salary = 3100.00m,
                    IsActive = true
                },     new Employee
                {
                    FirstName = "Edwina",
                    LastName = "Sneed",
                    Description = "Hair dresser",
                    DateOfBirth = DateTime.Now.AddYears(-29),
                    Country = "USA",
                    State = "NY",
                    Salary = 5100.00m,
                    IsActive = true
                },
                    new Employee
                {
                    FirstName = "Paul",
                    LastName = "Mustafa",
                    Description = "Carpenter",
                    DateOfBirth = DateTime.Now.AddYears(-45),
                    Country = "USA",
                    State = "NY",
                    Salary = 3300.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Shelly",
                    LastName = "Genovese",
                    Description = "Slelly grooming",
                    DateOfBirth = DateTime.Now.AddYears(-23),
                    Country = "IN",
                    State = "MH",
                    Salary = 2300.00m,
                    IsActive = true
                },     new Employee
                {
                    FirstName = "Brianna",
                    LastName = "Delembert",
                    Description = "Teacher",
                    DateOfBirth = DateTime.Now.AddYears(-45),
                    Country = "USA",
                    State = "WV",
                    Salary = 7390.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Eric",
                    LastName = "Marrassee",
                    Description = "Erie",
                    DateOfBirth = DateTime.Now.AddYears(-34),
                    Country = "US",
                    State = "MO",
                    Salary = 3100.00m,
                    IsActive = true
                }  ,new Employee
                {
                    FirstName = "Nancy",
                    LastName = "Washington",
                    Description = "Nancy's Home cooked tamales",
                    DateOfBirth = DateTime.Now.AddYears(-24),
                    Country = "USA",
                    State = "OK",
                    Salary = 133500.00m,
                    IsActive = true
                },  new Employee
                {
                    FirstName = "LaQuan",
                    LastName = "Marshall",
                    Description = "Sheriff deputy",
                    DateOfBirth = DateTime.Now.AddYears(-28),
                    Country = "USA",
                    State = "GA",
                    Salary = 4410.00m,
                    IsActive = false
                },     new Employee
                {
                    FirstName = "Anna",
                    LastName = "Warfield",
                    Description = "Administrative assistant",
                    DateOfBirth = DateTime.Now.AddYears(-57),
                    Country = "USA",
                    State = "MA",
                    Salary = 71300.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Kevin",
                    LastName = "McWorther",
                    Description = "The Professor",
                    DateOfBirth = DateTime.Now.AddYears(-54),
                    Country = "USA",
                    State = "ID",
                    Salary = 85200.00m,
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Michael",
                    LastName = "Allaniz",
                    Description = "Security guard",
                    DateOfBirth = DateTime.Now.AddYears(-39),
                    Country = "USA",
                    State = "NY",
                    Salary = 4000.00m,
                    IsActive = true
                },
                   new Employee
                {
                    FirstName = "Early",
                    LastName = "Quinto",
                    Description = "Laborer",
                    DateOfBirth = DateTime.Now.AddYears(-39),
                    Country = "USA",
                    State = "OK",
                    Salary = 1900.00m,
                    IsActive = true
                },
                 new Employee
                {
                    FirstName = "Brian",
                    LastName = "Levinson",
                    Description = "TV Extra",
                    DateOfBirth = DateTime.Now.AddYears(-30),
                    Country = "USA",
                    State = "CA",
                    Salary = 15200.00m,
                    IsActive = true
                },
                 new Employee
                {
                    FirstName = "Jeremy",
                    LastName = "Robard",
                    Description = "Line cook",
                    DateOfBirth = DateTime.Now.AddYears(-22),
                    Country = "USA",
                    State = "NM",
                    Salary = 8200.00m,
                    IsActive = true
                }   ,new Employee
                {
                    FirstName = "Betty",
                    LastName = "Nguyen",
                    Description = "Nurse",
                    DateOfBirth = DateTime.Now.AddYears(-39),
                    Country = "USA",
                    State = "AZ",
                    Salary = 1900.00m,
                    IsActive = true
                },
                  new Employee
                {
                    FirstName = "Mohammed",
                    LastName = "Hajj",
                    Description = "Truck driver",
                    DateOfBirth = DateTime.Now.AddYears(-54),
                    Country = "USA",
                    State = "VA",
                    Salary = 1900.00m,
                    IsActive = true
                },
                 new Employee
                {
                    FirstName = "Travis",
                    LastName = "Roberts",
                    Description = "Anchorman",
                    DateOfBirth = DateTime.Now.AddYears(-54),
                    Country = "USA",
                    State = "NV",
                    Salary = 15200.00m,
                    IsActive = true
                },   new Employee
                {
                    FirstName = "Marissa",
                    LastName = "George",
                    Description = "Minister",
                    DateOfBirth = DateTime.Now.AddYears(-39),
                    Country = "USA",
                    State = "AR",
                    Salary = 1900.00m,
                    IsActive = true
                },
                 new Employee
                {
                    FirstName = "Jamaal",
                    LastName = "Lane",
                    Description = "Anestsiologist",
                    DateOfBirth = DateTime.Now.AddYears(-30),
                    Country = "USA",
                    State = "ME",
                    Salary = 15200.00m,
                    IsActive = true
                },
                  new Employee
                {
                    FirstName = "David",
                    LastName = "Henry",
                    Description = "Mechanic",
                    DateOfBirth = DateTime.Now.AddYears(-54),
                    Country = "USA",
                    State = "MI",
                    Salary = 1900.00m,
                    IsActive = true
                },
                      new Employee
                {
                    FirstName = "Angie",
                    LastName = "Hillman",
                    Description = "Civil Engineer",
                    DateOfBirth = DateTime.Now.AddYears(-54),
                    Country = "USA",
                    State = "MN",
                    Salary = 6900.00m,
                    IsActive = true
                }
            };
            list.ForEach(m =>
            {
                context.Employees.Add(m);
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}