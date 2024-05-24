using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using OOPGAME.Objects.SuperClasses;
namespace OOPGAME.Objects
{
    internal class Orc : Entity
    {
        private int Stench;
        public Orc(int Stench, string Name, int Health) : base(Name, Health)
        {
            this.Stench = Stench;
        }
        public string GetStenchAndName()
        {
            return Name + " has a stench level of " + Stench;
        }
    }
}
