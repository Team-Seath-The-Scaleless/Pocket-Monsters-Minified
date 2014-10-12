namespace Abilities
{
    using System;

    public class Flamestrike : SpecialAbility
    {
        public const int FlamestrikeDamage = 6; // if pokemon max health = ~20/30.
        
        public const int FlamestrikeHitChance = 7;

        private bool flamestrikeHit;

        protected Flamestrike(int flamestrikeDamage)
            : base(AbilityType.Battle, FlamestrikeHitChance)
        {
            this.flamestrikeHit = this.TargetIsHit();
        }

        // do dmg method , enemyCurrentHP - FlamestrikeDamage 
    }
}