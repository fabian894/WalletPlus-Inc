using WalletPlusInc.Data.Entities;

namespace WalletPlusInc.Data
{
    public static class SeedHelper
    {
        public static async Task InitializeData(ApplicationDbContext context)
        {
            //1. check if customers contain data
            if (!context.Customers.Any())
            {
                //2. create sample data
                context.Customers.Add(new Customer
                {

                    FirstName = "Nola",
                    LastName = "Adeagbo",
                    MiddleName = "Adeagbo",
                    BirthDate = DateTime.Now.AddYears(-20),
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum2.Single,
                    CreatedDate = DateTime.Now,
                    Country = "Nigeria",
                    State = "Lagos",
                    City = "Ikeja",
                    Active = true
                });

                context.Customers.Add(new WalletPlusInc.Data.Entities.Customer
                {
                    FirstName = "Chibuzor",
                    LastName = "Nweke",
                    MiddleName = "Francis",
                    BirthDate = DateTime.Now.AddYears(-10),
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum2.Single,
                    Country = "Nigeria",
                    State= "Anambra",
                    City = "Nnewi",
                    CreatedDate = DateTime.Now,
                    Active = false
                });

                await context.SaveChangesAsync();
            }

            if (!context.Countries.Any())
            {
               

                context.Countries.AddRange(new List<Country>
                {
                   new Country { Name = "Afghanistan", IsoCode = "AFG", CallCode = "93" },
                    new Country { Name = "Albania", IsoCode = "ALB", CallCode = "355" },
                     new Country { Name = "Algeria", IsoCode = "DZA", CallCode = "213" },
                });
                await context.SaveChangesAsync();
            }

            if (!context.Cities.Any())
            {
                context.Cities.AddRange(new List<City>
                {
                    new City { Name = "New York", IsoCode = "NY", CallCode = "101" },
                    new City { Name = "Texax", IsoCode = "TEX", CallCode = "207" },
                     new City { Name = "California", IsoCode = "CAL", CallCode = "321" },
                });
                await context.SaveChangesAsync();
            }

            if (!context.States.Any())
            {
                context.States.AddRange(new List<State>
                {
                    new State { Name = "Lagos", IsoCode = "LAG", CallCode = "101" },
                    new State { Name = "Abuja", IsoCode = "ABJ", CallCode = "207" },
                     new State { Name = "PortHarCourt", IsoCode = "PH", CallCode = "321" },
                });
                await context.SaveChangesAsync();
            }

        }
    }
}
