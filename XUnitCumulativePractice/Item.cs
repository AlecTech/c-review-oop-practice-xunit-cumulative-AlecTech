using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitCumulativePractice
{
    public class Item
    {
        public string Name { get; set; }

        public Item() 
        {
            Name = "myName";
        }

        public Item( string name) 
        {
            Name = name;
        }
    }
}
