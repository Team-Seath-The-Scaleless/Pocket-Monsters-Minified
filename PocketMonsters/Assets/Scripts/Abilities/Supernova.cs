namespace Abilities
{
    using System;

    public class Supernova : SpecialAbility
    {
        public const int SupernovaDamage = 10; // if pokemon max health = ~20/30.

        public const int SupernovaHitChance = 5;

        private bool supernovaHit;

        protected Supernova(int supernovaDamage)
            : base(AbilityType.Battle, SupernovaHitChance)
        {
            this.supernovaHit = this.TargetIsHit();
        }

        // do dmg method , enemyCurrentHP - SupernovaDamage 
    }
}