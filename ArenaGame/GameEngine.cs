using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame {
    public class GameEngine {
        public class NotificationArgs {
            public Warior Attacker { 
                get; 
                set; 
            }
            public Warior Defender { 
                get; 
                set; 
            }
            public double Attack { 
                get; 
                set; 
            }
            public double Damage { 
                get; 
                set; 
            }
        }

        public delegate void GameNotifications(NotificationArgs args);

        private Random random = new Random();
        public Warior WarriorA { 
            get; 
            set; 
        }
        public Warior WarriorB {
            get; 
            set; 
        }
        public Warior Winner { 
            get; 
            set; 
        }
        public GameNotifications? NotificationsCallBack { 
            get; 
            set; 
        }
        public void Fight() {
            Warior attacker;
            Warior defender;

            double probability = random.NextDouble();
            if (probability < 0.5) {
                attacker = WarriorA;
                defender = WarriorB;
            } else {
                attacker = WarriorB;
                defender = WarriorA;
            }

            while (attacker.IsAlive) {
                double attack = attacker.Attack();
                double actualDamage = defender.Defend(attack);

                if (NotificationsCallBack != null) {

                    NotificationsCallBack(new NotificationArgs() {
                        Attacker = attacker,
                        Defender = defender,
                        Attack = attack,
                        Damage = actualDamage
                    }); 
                }

                Warior tempHero = attacker;
                attacker = defender;
                defender = tempHero;
            }
            Winner = defender;
        }
    }
}
