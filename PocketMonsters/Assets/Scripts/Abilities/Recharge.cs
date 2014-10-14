namespace Abilities
{
    using System;

    public class Recharge : SpecialAbility
    {
        public const int RechargeHeal = 5; // if pokemon max health = ~20/30.

        public const int RechargeHitChance = 8;

        public const int RechargeCooldown = 2;

        private bool rechargeHit;

        private string rechargeOnHit = "The strong lightning force recharges your health!";

        private string rechargeOnMiss = "You failed to recharge!";

        protected Recharge(int rechargeHeal, int rechargeCooldown)
            : base(AbilityType.Battle, RechargeHitChance)
        {
            this.rechargeHit = this.TargetIsHit();
        }

        public string RechargeOnHit
        {
            get
            {
                return this.rechargeOnHit;
            }
        }

        public string RechargeOnMiss
        {
            get
            {
                return this.rechargeOnMiss;
            }
        }

        // do heal method , allyCurrentHP + RechargeHeal 
    }
}