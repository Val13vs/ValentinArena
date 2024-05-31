using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Hitman : Warior
    {

        public Hitman(string name, double armor, double strenght, IGun? weapon = null, IProGun? proWeapon = null) : base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();
            
            return damage;
        }
        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }
    }
}
