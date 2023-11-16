using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemoSoldier
{
    internal class Armor
    {
        private string name;
        private int durability;
        private int defence;

        public Armor(string name, int durability, int defence) 
        {
            this.name = name;
            this.durability = durability;  
            this.defence = defence;
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

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }
    }
}
