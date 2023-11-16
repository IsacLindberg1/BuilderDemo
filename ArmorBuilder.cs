using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemoSoldier
{
    internal class ArmorBuilder
    {
        private string name;
        private int durability;
        private int defence;

        public ArmorBuilder Name (string name)
        {
            this.name = name;
            return this;
        }

        public ArmorBuilder Durability (int durability)
        {
            this.durability = durability;
            return this;
        }

        public ArmorBuilder Defence (int defence)
        {
            this.defence = defence;
            return this;
        }

        public Armor Build()
        {
            return new Armor(name, durability, defence);
        }
    }
}
