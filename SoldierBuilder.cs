using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemoSoldier
{
    internal class SoldierBuilder
    {
        private string name;
        private int health;
        private int age;
        private List<Armor> armors;
        private Weapon weapon;

        public SoldierBuilder Name(string name)
        {
            this.name = name;
            return this;
        }

        public SoldierBuilder Health (int health)
        {
            this.health = health;
            return this;
        }

        public SoldierBuilder Age (int age)
        {
            this.age = age;
            return this;
        }

        public SoldierBuilder AddArmor(Armor armor)
        {
            armors.Add(armor);
            return this;
        }

        public SoldierBuilder Weapon(Weapon weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public Soldier Build()
        {
            return new Soldier(name, health, age, armors, weapon);
        }
    }
}
