using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bomb : IGun, IProGun
    { 
        public string Name { 
            get; 
            set; 
        }
        public double AttackDamage { 
            get; 
            set; 
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

        public Bomb(string name) {
            Name = name;
            AttackDamage = 35;
            BlockPower = 0;
            SpecialSkillMethod = Explosion;
            SpecialSkillMethodDefence = FireExplosion;
        }

        public double Explosion() {
            return 4;
        }

        public double FireExplosion() {
            return AttackDamage * 4;
        }
    }
}
