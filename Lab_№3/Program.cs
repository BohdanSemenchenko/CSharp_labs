using System;

namespace Lab3
{
    public interface IDamageable
    {
        void TakeDamage(int damage);
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IDamageable enemy = new Enemy(50);
            IDamageable wall = new BreakableWall(30);

            Projectile bullet = new Bullet(20);

            Console.WriteLine("Bullet hit enemy:");
            bullet.HitTarget(enemy);

            Console.WriteLine("\nBullet hit wall:");
            bullet.HitTarget(wall);
        }
    }
}
