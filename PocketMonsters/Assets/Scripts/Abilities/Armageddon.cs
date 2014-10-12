namespace Abilities
{
    using System;

    public class Armageddon : SpecialAbility
    {
        public const int ArmageddonDamage = 15; // if pokemon max health = ~20/30.
        public const AbilityType ArmageddonSpellType = AbilityType.Battle;
        public const int ArmageddonHitChance = 3;
        bool ArmageddonHit;

        protected Armageddon(int ArmageddonDamage)
            : base(ArmageddonSpellType, ArmageddonHitChance)
        {
            ArmageddonHit = targetHit();
        }
        // do dmg method , enemyCurrentHP - ArmageddonDamage 
    }
}