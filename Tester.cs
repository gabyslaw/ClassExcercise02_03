using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.ClassExcercise02_03
{
    public class Tester
    {
        public static void Main()
        {
            //sum of the prices
            var TotalPrice = InventoryManager.GetInventories().Sum(x => x.Price);

            Console.WriteLine("..................................SkipWhile and TakeWhile......................................");
            //SkipWhile and TakeWhile
            var selection2 = InventoryManager.GetInventories()
                .SkipWhile(n => n.Id > 5)
                .TakeWhile(n => n.Id < 8);

            foreach (var item in selection2)
            {
                var Total1 = string.Format("{0:n0}", item.Price);
                Console.WriteLine($"Your Product ID is: {item.Id} and the Name is: " +
                    $"{item.Name} with a price of {Total1} \n");  
            }
            Console.WriteLine("..................................Order......................................");

            //Order by and Then by
            var Order = InventoryManager.GetInventories().OrderBy(c => c.Id).ThenBy(c => c.EntryDate);
            foreach (var order in Order)
            {
                var Total2 = string.Format("{0:n0}", order.Price);
                Console.WriteLine($"{order.Id}. {order.Name}, {Total2}, {order.EntryDate} \n");
            }

            Console.WriteLine("................................Order and Then by Descending.................................");

            //Order by Descending and Then by Descending
            var OrderByDescending = InventoryManager.GetInventories().OrderByDescending(c => c.Id).ThenByDescending(c => c.EntryDate);
            foreach (var order in OrderByDescending)
            {
                var Total3 = string.Format("{0:n0}", order.Price);
                Console.WriteLine($"{order.Id}. {order.Name}, {Total3}, {order.EntryDate.ToString("MM/dd/yyyy hh:mm:ss tt")} \n");
            }
            Console.WriteLine("..................................Concat.........................................");

            //Concat
            var Concat = InventoryManager.GetInventories().Concat(InventoryManager.FreshInventories());
            foreach (var item in Concat)
            {
                var Total4 = string.Format("{0:n0}", item.Price);
                Console.Write($" {item.Id}. {item.Name}, {Total4}, {item.EntryDate.ToString("MM/dd/yyyy hh:mm:ss tt")} \n\n");
            }
             Console.WriteLine("..........................Union...........................................");

            //Union
            var Union = InventoryManager.GetInventories().Union(InventoryManager.FreshInventories(), new InventoryComparer());
            foreach (var item in Union)
            {
                var Total5 = string.Format("{0:n0}", item.Price);
                Console.Write($" {item.Id}. {item.Name}, {Total5}, {item.EntryDate.ToString("MM/dd/yyyy hh:mm:ss tt")} \n\n");
            }
            Console.WriteLine("......................Intercept.........................................");

            var Intercept = InventoryManager.GetInventories().Intersect(InventoryManager.FreshInventories(), new InventoryComparer());
            foreach (var item in Intercept)
            {
                var Total6 = string.Format("{0:n0}", item.Price);
                Console.Write($" {item.Id}. {item.Name}, {Total6}, {item.EntryDate.ToString("MM/dd/yyyy hh:mm:ss tt")} \n\n");
            }

            Console.WriteLine("............................Except.........................................");

            var Except = InventoryManager.GetInventories().Except(InventoryManager.FreshInventories(), new InventoryComparer());
            foreach (var item in Except)
            {
                var Total7 = string.Format("{0:n0}", item.Price);
                Console.Write($" {item.Id}. {item.Name}, {Total7}, {item.EntryDate.ToString("MM/dd/yyyy hh:mm:ss tt")} \n\n");
            }

            Console.WriteLine("......................Distinct.........................................");

            var Distinct = InventoryManager.GetInventories().Distinct();
            foreach (var item in Distinct)
            {
                var Total8 = string.Format("{0:n0}", item.Price);
                Console.Write($" {item.Id}. {item.Name}, {Total8}, {item.EntryDate.ToString("MM/dd/yyyy hh:mm:ss tt")} \n\n");
            }
            Console.WriteLine("........................Sum of Prices................................");
            //Sum of the Prices
            var Total = string.Format("{0:n0}", TotalPrice);
            Console.WriteLine($"The Total price of all the product is: {Total}");
            Console.ReadLine();
        }
    }
}
