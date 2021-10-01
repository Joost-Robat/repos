using System;

namespace EnemyCSharp
{
    public class Enemy
    {
        public float health = 20;
        public float damage;
        public bool endGoal;
        public string naam { get; set; }
        public string favEten { get; set; }

        public void Damage()
        {
            damage = health;
            Console.WriteLine("Did " + damage + " damage.");
        }
    }
}
