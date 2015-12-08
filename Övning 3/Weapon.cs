using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    class Weapon
    {
        private string weapon;
        private int numberOfWeapons;

        public string GetWeapon()
        {
            return weapon;
        }

        public void SetWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public int GetNumberOfWeapons()
        {
            return numberOfWeapons;
        }
        public void SetNumberOfWeapons(int numberOfWeapons)
        {
            this.numberOfWeapons = numberOfWeapons;
        }
    }
}
