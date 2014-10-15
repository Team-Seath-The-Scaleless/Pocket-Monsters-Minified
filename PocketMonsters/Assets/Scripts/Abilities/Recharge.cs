namespace Abilities
{
    using System;

    public class Recharge : SpecialAbility
    {
        public const int RechargeHeal = 5; 

        public const int RechargeHitChance = 8;

        public const int RechargeCooldown = 2;

        public const string RechargeHitMessage = "The strong lightning force recharges your health!";

        public const string RechargeMissMessage = "You failed to recharge!";

        protected Recharge()
            : base(AbilityType.Battle, RechargeHitChance)
        {
            this.RechargeHit = this.TargetIsHit();
        }

        public bool RechargeHit { get; private set; }
    }
}