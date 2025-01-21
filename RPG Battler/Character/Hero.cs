using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Equipment> Equipment { get; set; }
        Random num = new Random();

        public Hero()
        {
            Name = "Unknown";
            Power = 1;
            Health = 1;
            Mana = 1;
            Level = 0;
        }

        public void LevelUp(CombatClass character)
        {
            
            switch (character)
            {
                case CombatClass.Wizard:
                    Health += num.Next(1, 16);
                    Power += num.Next(3, 6);
                    Luck += num.Next(1, 4);
                    Level += 1;
                    break;
                case CombatClass.Warrior:
                    Health += num.Next(10, 21);
                    Power += num.Next(1, 4);
                    Luck += num.Next(1, 4);
                    Level += 1;
                    break;
                case CombatClass.Rogue:
                    Health += num.Next(1, 16);
                    Power += num.Next(1, 4);
                    Luck += num.Next(3, 6);
                    Level += 1;
                    break;
                default:
                    break;
            }
        }

        public void DisplayStats(bool showTotalStats = false)
        {

        }

        public void PowerLevel(int levelUp)
        {
            if(levelUp > 50)
            {
                LevelUp(CombatClass);
            }
        }

        public void AwakenHero()
        {
            CombatClass = (CombatClass)num.Next(0,4);
            while(Level < num.Next(8, 13))
            {
                LevelUp(CombatClass);
            }
        }


        public void CalculateTotals()
        {
        }
    }
}
