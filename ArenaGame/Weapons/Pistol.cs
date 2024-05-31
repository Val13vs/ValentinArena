using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Pistol : IGun, IProGun
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
        public SpecialSkills? SpecialSkillMethodDefence { 
            get; 
            set; 
        }

        public Pistol(string name) {
            Name = name;
            AttackDamage = 18;
            BlockPower = 2;
            SpecialSkillMethodDefence = LongShot;
            SpecialSkillMethod = ExplosiveBullet;
        }
        public double ExplosiveBullet() {
            return 0;
        }
        public double LongShot() {
            return BlockPower * 15;
        }
    }
}
