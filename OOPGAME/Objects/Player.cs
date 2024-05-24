using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPGAME.Objects
{
    internal class Player
    {
        private string Name;
        private int Health;
        private int Damage;
        private int Heal;
        private int MaxHealth;
        private int Level = 1;
        private int Experience = 0;

        public Player(string Name, int Health, int MaxHealth)
        {
            this.Name = Name;
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            Random rand = new Random();
            Damage = 7;
            Heal = rand.Next(11, 22);
       
            
        }

        public string GetName()
        {
            return Name;
        }

        public int GetHealth()
        {
            return Health;
        }

        public int GetDamage()
        {
            return Damage;
        }
        public void DoHeal()
        {
            
            Health = Health+ Heal;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        public int GetHeal()
        {
            return Heal;
        }
        public void TakeDamage(Enemy enemy)
        {
            Health -= enemy.GetDamage();
        }
        public void ForceDeath()
        {
            Health -= 1000000000;
        }

        
        public void EarnExp(Enemy enemy)
        {
            if( enemy.GetHealth() <= 0)
            {
                Experience += 25;
            }
        }
        public int GetExp()
        {
            return Experience;
        }

        public void LevelUp()
        {
            double y= 100.0;
            if (Experience == y)
            {
                Console.WriteLine("player has leveled up");
                Level += 1;
                y *= 1.2;
                
                Random rand = new Random();
                MaxHealth += rand.Next(5, 11);
                Health = MaxHealth;
                Damage += rand.Next(1, 4);
                Experience = 0;

            }
        }
    }
}
