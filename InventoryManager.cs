using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.ClassExcercise02_03
{
    public class InventoryManager
    {
        public static IEnumerable<Inventory> FreshInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {
                new Inventory()
                {
                    Name = "IPhone X",
                    Price = 200000,
                    Categories = new List<Category>{ GetCategories()[2] }

                },

                new Inventory()
                {
                    Name = "Samsung S9",
                    Price = 450000,
                    Categories = new List<Category>{ GetCategories()[2] }
                },

                 new Inventory()
                 {
                    Name = "Surface Book 2",
                    Price = 625000,
                    Categories = new List<Category>{ GetCategories()[1] }
                 },

                  new Inventory()
                 {
                    Name = "HP Gaby",
                    Price = 250000,
                    Categories = new List<Category>{ GetCategories()[1] }
                 },

                   new Inventory()
                 {
                    Name = "Mouse",
                    Price = 10000,
                    Categories = new List<Category>{ GetCategories()[0] }
                 },

            };

            return inventories;

        }
        public static IEnumerable<Inventory> GetInventories()
        {

            Random r = new Random();
            List<Inventory> inventories = new List<Inventory>()
            {

                new Inventory()
                {
                    Id = 1,
                    Name = "Lenovo X1 Carbon",
                    Price = 300000,
                    EntryDate = DateTime.Now,
                    //.AddHours(r.Next()),
                    Categories = new List<Category>{ GetCategories()[1] }
                    //Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Keyboard",
                    Price = 8000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                {
                    Id = 3,
                    Name = "VGA Converter",
                    Price = 5000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                {
                    Id = 4,
                    Name = "Speaker",
                    Price = 40000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                {
                    Id = 5,
                    Name = "HP Gaby",
                    Price = 300000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[1] }
                },

                 new Inventory()
                {
                    Id = 6,
                    Name = "HTC one A9",
                    Price = 80000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[2] }
                },

                 new Inventory()
                {
                    Id = 7,
                    Name = "Nokia 6",
                    Price = 130000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[2] }
                },

                 new Inventory()
                {
                    Id = 8,
                    Name = "Samsung S8",
                    Price = 225000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[2] }
                },

                 new Inventory()
                {
                    Id = 9,
                    Name = "Macbook",
                    Price = 900000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[1] }
                },

                 new Inventory()
                {
                    Id = 10,
                    Name = "Beats by Gaby Headset",
                    Price = 75000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[0] }
                },
            };

            return inventories;

        }

        public static List<Category> GetCategories()
        {
            Category[] categories = new Category[3]
            {
                new Category(){ Name = "Computer Accessories"},
                 new Category(){ Name = "Laptop"},
                    new Category(){ Name = "Phone"},
            };

            return categories.ToList();
        }
    }
}
