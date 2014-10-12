namespace Abilities
{
    using System;

    public class Thundershock : SpecialAbility
    {

        public const int ThundershockDamage = 5; // if pokemon max health = ~20/30.
        public const AbilityType ThundershockSpellType = AbilityType.Battle;
        public const int ThundershockHitChance = 8;
        bool ThundershockHit;

        protected Thundershock(int ThundershockDamage)
            : base(ThundershockSpellType, ThundershockHitChance)
        {
            ThundershockHit = targetHit();
        }
        // do dmg method , enemyCurrentHP - ThundershockDamage 
    }
}
