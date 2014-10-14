namespace Abilities
{
    using System;

    public class Thundershock : SpecialAbility
    {
        private int thundershockDamage = 5; 

        public const int ThundershockHitChance = 8;

        private int thundershockCooldown = 1;

        private bool thundershockHit;

        private string thundershockOnHit = "The target has been thudnershocked!";

        private string thundershockOnMiss = "Thundershock has missed the target!";

        protected Thundershock(int thundershockDamage, int thundershockCooldown)
            : base(AbilityType.Battle, ThundershockHitChance)
        {
            this.thundershockHit = this.TargetIsHit();
        }
   
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

        public int ThundershockDamage
        {
            get
            {
                return this.thundershockDamage;
            }
        }

        public int ThundershockCooldown
        {
            get
            {
                return this.thundershockCooldown;
            }
        }

    }
}
