using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    using System;

    public class BreakableWall : IDamageable
    {
        public int Durability { get; private set; }

        public BreakableWall(int durability)
        {
            Durability = durability;
        }

        public void TakeDamage(int damage)
        {
            Durability -= damage;
            Console.WriteLine($"Wall received {damage} damage. Remaining strength: {Durability}");
            if (Durability <= 0)
            {
                Console.WriteLine("The wall is destroyed");
            }
        }
    }
}
