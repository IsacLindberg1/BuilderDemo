using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemoSoldier
{
    internal class Weapon
    {
        private string name;
        private int durability;
        private int strength;
        private double weight;

        public Weapon(string name, int durability, int strength, double weight)
        {
            this.name = name;
            this.durability = durability;
            this.strength = strength;
            this.weight = weight;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        public int Strength
        {
            get { return strength; ; }
            set { strength = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
