using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TurtlePower();
            CirclePower();
            PointPower();
            TransformPointWithCircle();
            HeroPower();
            PlayOcarina();
            System.Threading.Thread.Sleep(9000);
        }

        private static void PlayOcarina()
        {
            Console.Beep(480, 200);
            Console.Beep(1568, 200);
            Console.Beep(1568, 200);
            Console.Beep(1568, 200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(783, 200);
            Console.Beep(783, 200);
            Console.Beep(369, 200);
            Console.Beep(392, 200);
            Console.Beep(369, 200);
            Console.Beep(392, 200);
            Console.Beep(392, 400);
            Console.Beep(196, 400);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(783, 200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(783, 200);
            Console.Beep(739, 200);
            Console.Beep(83, 200);
            Console.Beep(880, 200);
            Console.Beep(830, 200);
            Console.Beep(880, 200);
            Console.Beep(987, 400);
            Console.Beep(880, 200);
            Console.Beep(783, 200);
            Console.Beep(698, 200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(783, 200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(783, 200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(880, 200);
            Console.Beep(830, 200);
            Console.Beep(880, 200);
            Console.Beep(987, 400);
            System.Threading.Thread.Sleep(200);
            Console.Beep(1108, 10);
            Console.Beep(1174, 200);
            Console.Beep(1480, 10);
            Console.Beep(1568, 200);
            System.Threading.Thread.Sleep(200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(783, 200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(783, 200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(880, 200);
            Console.Beep(830, 200);
            Console.Beep(880, 200);
            Console.Beep(987, 400);
            Console.Beep(880, 200);
            Console.Beep(783, 200);
            Console.Beep(698, 200);
            Console.Beep(659, 200);
            Console.Beep(698, 200);
            Console.Beep(784, 200);
            Console.Beep(880, 400);
            Console.Beep(784, 200);
            Console.Beep(698, 200);
            Console.Beep(659, 200);
            Console.Beep(587, 200);
            Console.Beep(659, 200);
            Console.Beep(698, 200);
            Console.Beep(784, 400);
            Console.Beep(698, 200);
            Console.Beep(659, 200);
            Console.Beep(587, 200);
            Console.Beep(523, 200);
            Console.Beep(587, 200);
            Console.Beep(659, 200);
            Console.Beep(698, 400);
            Console.Beep(659, 200);
            Console.Beep(587, 200);
            Console.Beep(493, 200);
            Console.Beep(523, 200);
            System.Threading.Thread.Sleep(400);
            Console.Beep(349, 400);
            Console.Beep(392, 200);
            Console.Beep(329, 200);
            Console.Beep(523, 200);
            Console.Beep(493, 200);
            Console.Beep(466, 200);
            Console.Beep(440, 200);
            Console.Beep(493, 200);
            Console.Beep(523, 200);
            Console.Beep(880, 200);
            Console.Beep(493, 200);
            Console.Beep(880, 200);
            Console.Beep(1760, 200);
            Console.Beep(440, 200);
            Console.Beep(392, 200);
            Console.Beep(440, 200);
            Console.Beep(493, 200);
            Console.Beep(783, 200);
            Console.Beep(440, 200);
            Console.Beep(783, 200);
            Console.Beep(1568, 200);
            Console.Beep(392, 200);
            Console.Beep(349, 200);
            Console.Beep(392, 200);
            Console.Beep(440, 200);
            Console.Beep(698, 200);
            Console.Beep(415, 200);
            Console.Beep(698, 200);
            Console.Beep(1396, 200);
            Console.Beep(349, 200);
            Console.Beep(329, 200);
            Console.Beep(311, 200);
            Console.Beep(329, 200);
            Console.Beep(659, 200);
            Console.Beep(698, 400);
            Console.Beep(783, 400);
            Console.Beep(440, 200);
            Console.Beep(493, 200);
            Console.Beep(523, 200);
            Console.Beep(880, 200);
            Console.Beep(493, 200);
            Console.Beep(880, 200);
            Console.Beep(1760, 200);
            Console.Beep(440, 200);
            Console.Beep(392, 200);
            Console.Beep(440, 200);
            Console.Beep(493, 200);
            Console.Beep(783, 200);
            Console.Beep(440, 200);
            Console.Beep(783, 200);
            Console.Beep(1568, 200);
            Console.Beep(392, 200);
            Console.Beep(349, 200);
            Console.Beep(392, 200);
            Console.Beep(440, 200);
            Console.Beep(698, 200);
            Console.Beep(659, 200);
            Console.Beep(698, 200);
            Console.Beep(739, 200);
            Console.Beep(783, 200);
            Console.Beep(392, 200);
            Console.Beep(392, 200);
            Console.Beep(392, 200);
            Console.Beep(392, 200);
            Console.Beep(196, 200);
            Console.Beep(196, 200);
            Console.Beep(196, 200);
            Console.Beep(185, 200);
            Console.Beep(196, 200);
            Console.Beep(185, 200);
            Console.Beep(196, 200);
            Console.Beep(207, 200);
            Console.Beep(220, 200);
            Console.Beep(233, 200);
            Console.Beep(246, 200);
        }

        private static void HeroPower()
        {
            Console.WriteLine("\n*************Uppgift 5*************\n");
            Hero hero = new Hero();
            Hero age = new Hero();
            Hero loveInterest = new Hero();
            Hero enemy = new Hero();
            Hero missionInLifeSaveHyrule = new Hero();
            Hero missionInLifeSaveZelda = new Hero();
            Clothing tuniq = new Clothing();
            Clothing belt = new Clothing();
            Clothing hat = new Clothing();
            Clothing boots = new Clothing();
            Weapon sword = new Weapon();
            Weapon shield = new Weapon();
            Weapon magic = new Weapon();
            Backpack backpack1 = new Backpack();
            List<Item> items = new List<Item>();
            Item hookshot = new Item();
            Item map = new Item();
            Item key = new Item();
            Item heartcontainer = new Item();
            Item wallet = new Item();
            Item flute = new Item();
            Item magicspells = new Item();
            Item bean = new Item();
            Item oil = new Item();
            hero.SetName("Link");
            age.SetAge(17);
            tuniq.SetClothing("tuniq");
            tuniq.SetColor("green");
            belt.SetClothing("belt");
            belt.SetColor("black");
            hat.SetClothing("hat");
            hat.SetColor("green");
            boots.SetClothing("boots");
            boots.SetColor("brown");
            sword.SetWeapon("sword");
            shield.SetWeapon("shield");
            magic.SetWeapon("magic");
            enemy.SetEnemy("Ganon");
            loveInterest.SetLoveInterest("Zelda");
            missionInLifeSaveHyrule.SetMissionInLife("save Hyrule");
            missionInLifeSaveZelda.SetMissionInLife("save Zelda");
            hookshot.SetName("Hookshot");
            hookshot.SetType("Tool");
            map.SetType("Help");
            map.SetName("Map");
            key.SetType("Tool");
            key.SetName("Key");
            heartcontainer.SetType("Life");
            heartcontainer.SetName("Heart");
            wallet.SetType("Money");
            wallet.SetName("Wallet");
            flute.SetType("Tool");
            flute.SetName("Flute");
            magicspells.SetType("Tool");
            magicspells.SetName("Magic");
            bean.SetType("Tool");
            bean.SetName("Bean");
            oil.SetType("Tool");
            oil.SetName("Oil");
            items.Add(hookshot);
            items.Add(map);
            items.Add(key);
            items.Add(heartcontainer);
            items.Add(wallet);
            items.Add(flute);
            items.Add(magicspells);
            items.Add(bean);
            items.Add(oil);
                       
            Console.WriteLine($"Our hero´s name is {hero.GetName()}.\nHe is {age.GetAge()} years old.\nHe wears a {tuniq.GetColor()} {tuniq.GetClothing()} with a {belt.GetColor()} {belt.GetClothing()} to keep it closed. On his head he wears a {hat.GetColor()} {hat.GetClothing()} similar to Robin Hood almost, only cooler. To finish this set off with some style he wears a nice set of {boots.GetColor()} {boots.GetClothing()}");
            Console.WriteLine($"He has as any good hero has weapons. For starters he a great {sword.GetWeapon()} and for defence a big {shield.GetWeapon()}. To finish it off he has pleny of {magic.GetWeapon()}\nJust like any great hero he has an archenemy named {enemy.GetEnemy()}.\nOf course he has time for a love in his life, her name is {loveInterest.GetLoveInterest()}.\nOur hero´s quest or mission in life is to {missionInLifeSaveZelda.GetMissionInLife()} and in turn {missionInLifeSaveHyrule.GetMissionInLife()}");
            Console.WriteLine("\nThe Hero carries all of these items in his backpack!");

            foreach (var item in items)
            {
                Console.WriteLine(item.PrintItem());
            }
            
        }

        private static void TransformPointWithCircle()
        {
            Console.WriteLine("\n*************Uppgift 4*************\n");
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            Point centerOfCircle1 = new Point();
            Point centerOfCircle2 = new Point();
            centerOfCircle1.SetX(5);
            centerOfCircle1.SetY(5);
            centerOfCircle2.SetX(10);
            centerOfCircle2.SetY(10);
            circle1.SetDiameter(10);
            circle2.SetDiameter(50);
            circle1.SetCenter(centerOfCircle1);
            circle2.SetCenter(centerOfCircle2);
            
            Console.WriteLine($"The center of the first circle is = {circle1.GetCenter().GetX()},{circle1.GetCenter().GetY()}.\nThe diameter of the first circle is = {circle1.GetDiameter()}.\nThe circumference of the first circle is  = {circle1.GetCircumference()}.\n\nThe center of the second circle is = {circle2.GetCenter().GetX()},{circle2.GetCenter().GetY()}.\nThe diameter of the second circle is = {circle2.GetDiameter()}.\nThe circumference of the second circle is  = {circle2.GetCircumference()}");
        }

        private static void PointPower()
        {
            Console.WriteLine("\n*************Uppgift 3*************\n");
            Point point1 = new Point();
            Point point2 = new Point();
            point1.SetX(20);
            point1.SetY(20);
            point2.SetX(50);
            point2.SetY(50);
            Console.WriteLine($"First point of X is = {point1.GetX()} First point of Y is = {point1.GetY()} \nSecond point of X is = {point2.GetX()} Second point of Y is = {point2.GetY()}");
        }

        private static void CirclePower()
        {
            Console.WriteLine("\n*************Uppgift 2*************\n");
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            Circle circle3 = new Circle();
            Circle circle4 = new Circle();
            circle1.SetDiameter(25.4);
            circle2.SetDiameter(1.5);
            circle3.SetDiameter(7.799);
            circle4.SetDiameter(101.1);
            Console.WriteLine($"Circle 1´s circumference is = {circle1.GetCircumference()} \nCircle 2´s circumference is = { circle2.GetCircumference()} \nCircle 1´s circumference is = { circle3.GetCircumference()} \nCircle 4´s circumference is = { circle4.GetCircumference()}");
        }

        private static void TurtlePower()
        {
            Console.WriteLine("\n*************Uppgift 1*************\n");
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person();
            person1.SetName("Leonardo");
            person2.SetName("Michelangelo");
            person3.SetName("Donatello");
            person4.SetName("Raphael");
            Console.WriteLine($"{person1.GetName()} {person2.GetName()} {person3.GetName()} {person4.GetName()}");
        }
    }
}
