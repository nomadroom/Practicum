﻿namespace ShootBird
{
    internal class HeroEnemy : IEnemy
    {
        private readonly int enemyHelth;
        private readonly string enemyName;

        public HeroEnemy(string enemyName)
        {
            this.enemyHelth = 100;
            this.enemyName = enemyName;
        }

        public int EnemyHelth { get { return this.enemyHelth; } }
        public string EnemyName { get { return this.enemyName; } }



        public Task CreateEnemyAsync()
        {
            Console.WriteLine($"Внимание!" +
             $"\nПеред Вами появился монстр!" +
             $"\nИмя: {EnemyName} " +
             $"\nЗдоровье: {EnemyHelth}");
            return Task.CompletedTask;
        }


        public int StartEnemyHealth()
        {
            return EnemyHelth;
        }

    }
}
