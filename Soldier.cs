using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemoSoldier
{
    internal class Soldier
    {
        private string name;
        private int health;
        private int age;
        private List<Armor> armors;
        private Weapon weapon;

        public Soldier(string name, int health, int age, List<Armor> armors, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.age = age;
            this.armors = armors;
            this.weapon = weapon;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        { 
            get { return health; } 
            set {  health = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<Armor> Armors
        {
            get { return armors; }
            set { armors = value; }
        }

        public Weapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
    }
}
