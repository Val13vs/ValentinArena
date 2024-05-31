using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Fighter : Warior
    {
        public Fighter(string name, double armor, double strenght, IGun? weapon, IProGun? proWeapon = null) : base(name, armor, strenght, weapon)
        {
            
        }
        public override double Attack()
        {
            return base.Attack();
        }
        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }
    }
}
