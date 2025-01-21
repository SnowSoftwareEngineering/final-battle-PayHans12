using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Monster : Creations
    {
        public int DropExperience { get; set; }
        public CreatureRarity CreatureRarity { get; set; }

        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        Random num = new Random();

        public Monster()
        {
            double rarity = 100 * num.NextDouble();
            if (rarity < 60)
            {
                CreatureRarity = CreatureRarity.Common;
            }
            else if (rarity < 90)
            {
                CreatureRarity = CreatureRarity.Rare;
            }
            else if (rarity < 99)
            {
                CreatureRarity = CreatureRarity.Heroic;
            }
            else if (rarity > 99)
            {
                CreatureRarity = CreatureRarity.Legendary;
            }

            while (Level < num.Next(5, 15))
            {
                LevelUp(CreatureRarity);
            }
            Name = "UnknownBeast";
        }
        public void LevelUp(CreatureRarity CreatureRarity)
        {

            switch (CreatureRarity)
            {
                case CreatureRarity.Common:
                    Health += num.Next(2, 11);
                    Power += 2;
                    Luck += num.Next(1, 4);
                    Level += 1;
                    break;
                case CreatureRarity.Rare:
                    Health += num.Next(10, 14);
                    Power += num.Next(3, 5);
                    Luck += num.Next(3, 6);
                    Level += 1;
                    break;
                case CreatureRarity.Heroic:
                    Health += num.Next(12, 21);
                    Power += num.Next(3, 6);
                    Luck += num.Next(3, 8);
                    Level += 1;
                    break;
                case CreatureRarity.Legendary:
                    Health += num.Next(20, 41);
                    Power += num.Next(5, 13);
                    Luck += num.Next(10, 21);
                    Level += 1;
                    break;
                default:
                    break;
            }
        }

        public void PowerLevel(int levelUp)
        {
            if (levelUp > 50)
            {
                LevelUp(CreatureRarity);
            }
        }
    }




    public enum CreatureRarity
    {
        Common,
        Rare,
        Heroic,
        Legendary
    }
}
