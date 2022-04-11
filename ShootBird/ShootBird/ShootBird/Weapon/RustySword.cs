﻿using L.S.D.Interface;

namespace L.S.D.Weapon
{
    internal class RustySword : IWeapons
    {
        private readonly int endurance;
        private readonly int minDamageRange;
        private readonly int maxDamageRange;
        private readonly string weaponName;

        public RustySword()
        {
            endurance = 70;
            minDamageRange = 20;
            maxDamageRange = 25;
            weaponName = "Ржавый меч.";
        }

        public int Endurance => endurance;
        public int MinDamageRange => minDamageRange;
        public int MaxDamageRange => maxDamageRange;
        public string WeaponName => weaponName;

        /// <summary>
        /// Атака оружия.
        /// </summary>
        /// <returns>Вывод результата выстрела.</returns>
        public (int Endurance, int Damage) Attack()
        {
            Random random = new();
            int damage = random.Next(MinDamageRange, MaxDamageRange);
            return (Endurance, damage);
        }
        /// <summary>
        /// Информация о оружии
        /// </summary>
        public void AboutWeapon()
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                Получено новое оружие: ");
            Console.WriteLine($"\n {WeaponName}" +
                              $"\n Прочность: {Endurance}" +
                              $"\n Урон: {MinDamageRange} - {MaxDamageRange}");
            Console.WriteLine("                                                  Получено достижение 'Оружейник!'");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
        }

    }
}
