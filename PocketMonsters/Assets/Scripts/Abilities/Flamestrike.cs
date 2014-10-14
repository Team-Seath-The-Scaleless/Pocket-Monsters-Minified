namespace Abilities
{
    using System;

    public class Flamestrike : SpecialAbility
    {
        private int flamestrikeDamage = 6;

        public const int FlamestrikeHitChance = 7;

        private int flamestrikeCooldown = 2;

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

        public int FlamestrikeDamage
        {
            get
            {
                return this.flamestrikeDamage;
            }
        }

        public int FlamestrikeCooldown
        {
            get
            {
                return this.flamestrikeCooldown;
            }
        }
    }
}