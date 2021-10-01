using System;

namespace Persoon
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyCSharp.Enemy enemy = new EnemyCSharp.Enemy();
            enemy.naam = "GekkeHenk";
            enemy.favEten = "kip";
            enemy.endGoal = true;
        }
    }
}
