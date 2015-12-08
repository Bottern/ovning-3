using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    class Item
    {
        private string type;
        private string itemname;

        public string GetType()
        {
            return type;
        }
        public void SetType(string type)
        {
            this.type = type;
        }

        public string GetItemName()
        {
            return itemname;
        }
        public void SetName(string itemname)
        {
            this.itemname = itemname;
        }

        public string PrintItem()
        {
            return $"Type: {type}\nItemName: {itemname} ";
        }
    }
}
