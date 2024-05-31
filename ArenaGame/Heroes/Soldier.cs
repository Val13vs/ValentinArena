using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Soldier: Warior
    {
        private double hitCount;
        private double damageCoef;
        public Soldier(string name, double armor, double strenght, IGun? weapon = null, IProGun? proWeapon = null) : base(name, armor, strenght, weapon, proWeapon)
        {
            hitCount = 0;
            damageCoef = 0.6;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage * damageCoef;
            if (damageCoef < 1) damageCoef += 0.1;
            return realDamage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);

        }
    }
}
