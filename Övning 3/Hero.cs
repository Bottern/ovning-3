using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    class Hero
    {
        private string name;
        private int age;
        private string loveInterest;
        private string enemy;
        private string missionInLife;
        
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetLoveInterest()
        {
            return loveInterest;
        }
        public void SetLoveInterest(string loveInterest)
        {
            this.loveInterest = loveInterest;
        }

        public string GetEnemy()
        {
            return enemy;
        }

        public void SetEnemy(string enemy)
        {
            this.enemy = enemy;
        }

        public string GetMissionInLife()
        {
            return missionInLife;
        }

        public void SetMissionInLife(string missionInLife)
        {
            this.missionInLife = missionInLife;
        }
    }

}

        //private string Backpack;
        
