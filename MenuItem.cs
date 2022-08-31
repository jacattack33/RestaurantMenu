using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }    
        public bool IsNewItem { get; set; }   

        public MenuItem(string name, int price, string description, string category, bool isnewitem)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNewItem = isnewitem;
        }
    }
}
