using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    class Backpack
    {
        private List<Item> items;

        public List<Item> GetItems()
        {
            return items;
        } 
        public void SetItems(List<Item> items)
        {
            this.items = items;
        } 
    }
}
