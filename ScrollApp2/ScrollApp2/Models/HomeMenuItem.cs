using System;
using System.Collections.Generic;
using System.Text;

namespace ScrollApp2.Models
{
    public enum MenuItemType
    {
        Products,
        ShoppingCart,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }

        public string Name { get; set; }
    }
}
