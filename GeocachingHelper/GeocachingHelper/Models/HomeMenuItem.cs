using System;
using System.Collections.Generic;
using System.Text;

namespace GeocachingHelper.Models
{
    public enum MenuItemType
    {
        Welcome,
        ROT13Decrypt,
        ROT13Encrypt,
        GeocacheLogger,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
