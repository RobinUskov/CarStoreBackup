using CarStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Tests
{
    internal class LibraryServiceTests
    {
        public static class StaticData
        {
            public static List<Car> Cars = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                Model = "Model  1",
                BrandId = 1,
                ReleaseDate = new DateTime(2005,05,07)
            },
            new Car()
            {
                Id = 2,
                Model = "Model 2",
                BrandId = 2,
                ReleaseDate = new DateTime(2009,06,25)
            },
            new Car()
            {
                Id = 3,
                Model = "Model 3",
                BrandId = 3,
                ReleaseDate = new DateTime(2015,10,10)
            },
            new Car()
            {
                Id = 4,
                Model = "Model 4",
                BrandId = 1,
                ReleaseDate = new DateTime(2007,05,07)
            },
        };
            public static List<Brand> Brands = new List<Brand>()
        {
            new Brand()
            {
                Id = 1,
                Name = "BMW E46",
                Bio = "Bio 1"
            },
            new Brand()
            {
                Id = 2,
                Name = "Mercedes - Benz E550",
                Bio = "Bio 2"
            },
            new Brand()
            {
                Id = 3,
                Name = "Citroen C3",
                Bio = "Bio 3"
            },

        };
        }
    }
}

