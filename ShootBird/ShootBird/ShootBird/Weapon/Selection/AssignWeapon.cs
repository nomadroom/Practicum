﻿using ShootBird.Gun;


namespace ShootBird.Weapon.Selection
{
    internal class AssignFirstWeapon
    {
        private readonly int operationType;

        public AssignFirstWeapon(int operationType)
        {
            this.operationType = operationType;
        }
        public int OperationType => this.operationType;

        public  IWeapons AssignWeapon()
        {
            var weapons = new IWeapons[]
            {
                new RustySword(),
                new WoodenCrossbow(),
                new RodOfSparks(),               
            };

            var weapon = weapons[OperationType];
            return weapon;
        }
    }
}
