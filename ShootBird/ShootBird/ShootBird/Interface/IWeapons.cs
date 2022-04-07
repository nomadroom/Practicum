﻿namespace ShootBird.Gun
{
    internal interface IWeapons
    {
        int Endurance { get; }
        int MaxDamageRange { get; }
        int MinDamageRange { get; }
        string WeaponName { get; }

        void AboutWeapon();
        (int Endurance, int Damage) Attack();
    }
}