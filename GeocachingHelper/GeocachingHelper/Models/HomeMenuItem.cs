using System;
using System.Collections.Generic;
using System.Text;

namespace GeocachingHelper.Models
{
    public enum MenuItemType
    {
        
        Browse,
        About,
        About2
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
