using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Knife : IGun
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

        public Knife(string name)
        {
            Name = name;
            AttackDamage = 7;
            BlockPower = 10;
            SpecialSkillMethod = RootingOut;
        }

        public double RootingOut()
        {
            return AttackDamage * 1.5;
        }
    }
}
