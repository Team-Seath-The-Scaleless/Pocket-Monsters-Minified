namespace Abilities
{
    using System;

    public class Recharge : SpecialAbility
    {
        private int rechargeHeal = 5; 

        public const int RechargeHitChance = 8;

        private int rechargeCooldown = 2;

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

        public int RechargeHeal
        {
            get
            {
                return this.rechargeHeal;
            }
        }

        public int RechargeCooldown
        {
            get
            {
                return this.rechargeCooldown;
            }
        }
    }
}