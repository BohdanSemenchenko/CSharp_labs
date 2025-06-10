using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bullet : Projectile
    {
        public Bullet(int damage) : base(damage) { }

        public override void HitTarget(IDamageable target)
        {
            Console.WriteLine($"Bullet does {damage} damage");
            target.TakeDamage(damage);
        }
    }
}
