namespace Abilities
{
    using System;

    public class Flamestrike : SpecialAbility
    {
        public const int FlamestrikeDamage = 6; // if pokemon max health = ~20/30.
        public const AbilityType FlamestrikeSpellType = AbilityType.Battle;
        public const int FlamestrikeHitChance = 7;
        bool FlamestrikeHit;

        protected Flamestrike(int FlamestrikeDamage)
            : base(FlamestrikeSpellType, FlamestrikeHitChance)
        {
            FlamestrikeHit = targetHit();
        }
        // do dmg method , enemyCurrentHP - FlamestrikeDamage 
    }
}