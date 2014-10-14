namespace Abilities
{
    using System;

    public class Flamestrike : SpecialAbility
    {
        public const int FlamestrikeDamage = 6; // if pokemon max health = ~20/30.
        
        public const int FlamestrikeHitChance = 7;

        public const int FlamestrikeCooldown = 2;

        private bool flamestrikeHit;

        private string flamestrikeOnHit = "The enemy minion burst into flame!";

        private string flamestrikeOnMiss = "Flamestrike has missed the target!";

        protected Flamestrike(int flamestrikeDamage, int flamestrikeCooldown)
            : base(AbilityType.Battle, FlamestrikeHitChance)
        {
            this.flamestrikeHit = this.TargetIsHit();
        }

        public string FlamestrikeOnHit
        {
            get
            {
                return this.flamestrikeOnHit;
            }
        }

        public string FlamestrikeOnMiss
        {
            get
            {
                return this.flamestrikeOnMiss;
            }
        }

        // do dmg method , enemyCurrentHP - FlamestrikeDamage 
    }
}