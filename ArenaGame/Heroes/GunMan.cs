using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class GunMan : Warior
    {
        public GunMan(string name, double armor, double strenght, IGun? weapon, IProGun? proWeapon = null) : 
            base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            double probability = random.NextDouble();
            if (probability < 0.10)
            {
                damage *= 3;
            }
            return damage;
        }
    }
}
