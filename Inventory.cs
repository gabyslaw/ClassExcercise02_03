using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.ClassExcercise02_03
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
