using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Axe : IGun, IProGun
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

        public Axe(string name) {
            Name = name;
            AttackDamage = 15;
            BlockPower = 1;
            SpecialSkillMethod = Split;
            
        }
        public double Split() {
            return 0;
        }
    }
}
