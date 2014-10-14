namespace Abilities
{
    using System;

    public class Thundershock : SpecialAbility
    {
        public const int ThundershockDamage = 5; // if pokemon max health = ~20/30.

        public const int ThundershockHitChance = 8;

        public const int ThundershockCooldown = 1;

        private bool thundershockHit;

        private string thundershockOnHit = "The target has been thudnershocked!";

        private string thundershockOnMiss = "Thundershock has missed the target!";

        protected Thundershock(int thundershockDamage, int thundershockCooldown)
            : base(AbilityType.Battle, ThundershockHitChance)
        {
            this.thundershockHit = this.TargetIsHit();
        }
    // do dmg method , enemyCurrentHP - ThundershockDamage 
        
        public string ThundershockOnHit
        {
            get
            {
                return this.thundershockOnHit;
            }
        }

        public string ThundershockOnMiss
        {
            get
            {
                return this.thundershockOnMiss;
            }
        }

    }
}
