using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Enemy : IDamageable
    {
        public int Health { get; private set; }

        public Enemy(int health)
        {
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"Enemy has taken {damage} damage. Left health: {Health}");
            if (Health <= 0)
            {
                Console.WriteLine("Enemy killed");
            }
        }
    }
}
