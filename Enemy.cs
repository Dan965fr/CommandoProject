using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public bool IsAlive
        {
            get { return Health > 0; }
        }
        public Enemy(string name)
        {
            Name = name;
        }
        public void Screem()
        {
            Console.WriteLine("I'm Enemy!!!!!");

        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} is dead.");
            }
            else
            {
                Console.WriteLine($"{Name} took {damage} damage, remaining health: {Health}");
            }
        }

    }
}
