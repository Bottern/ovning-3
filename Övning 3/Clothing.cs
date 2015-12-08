using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    class Clothing
    {
        private string clothes;
        private string color;
        public string GetClothing()
        {
            return clothes;
        }
        public void SetClothing(string clothes)
        {
            this.clothes = clothes;
        }

        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
    }
}
