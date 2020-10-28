using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitCumulativePractice
{
    public class Storage
    {
        public List<Item> Contents { get; set; } = new List<Item>();

        public Storage()
        {
      
        }

        public void AddItem(Item item)
        {
            Contents.Add(item);

        }

        public void RemoveItem()
        {
            var last = Contents.LastOrDefault();
            if (last != null)
            {
                Contents.Remove(last);
            }
        }
    }
}
