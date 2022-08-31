using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    internal class Menu
    {
        public DateTime LastUpdated { get }   
        public List<MenuItem> Items { get; set; }
        public Menu(DateTime lastUpdated, List<MenuItem> items)
        {
            LastUpdated = lastUpdated;
            Items = items;
        }

        public void PrintMenu(MenuItem item)
        {
            Console.WriteLine($"\n{item.Name}, ${item.Price}\n{item.Description}");
            if (item.New)
            {
                Console.WriteLine("New Item");
            }
        }

    }
}
