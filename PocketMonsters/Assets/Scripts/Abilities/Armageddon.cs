namespace Abilities
{
    using System;

    public class Armageddon : SpecialAbility
    {
        public const int ArmageddonDamage = 15; // if pokemon max health = ~20/30.

        public const int ArmageddonHitChance = 3;

        private bool armageddonHit;

        protected Armageddon(int armageddonDamage)
            : base(AbilityType.Battle, ArmageddonHitChance)
        {
            this.armageddonHit = this.TargetIsHit();
        }

        // do dmg method , enemyCurrentHP - ArmageddonDamage 
    }
}