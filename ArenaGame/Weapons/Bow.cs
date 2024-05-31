using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bow : IGun, IProGun
    {
        public string Name { 
            get; 
            set; 
        }

        public double AttackDamage { 
            get; 
            private set; 
        }

        public double BlockPower { 
            get; 
            private set; 
        }

        public SpecialSkills? SpecialSkillMethod { 
            get; 
            set; 
        }

        public SpecialSkills? SpecialSkillMethodDefence { get; }

        public Bow(string name) {
            Name = name;
            AttackDamage = 5;
            BlockPower = 4;
            SpecialSkillMethod = FireArrow;
        }

        public double FireArrow() {
            return AttackDamage * 1.2;
        }
    }
}
