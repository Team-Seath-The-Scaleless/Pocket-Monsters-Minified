namespace Abilities
{
    using System;

    public class Recharge : SpecialAbility
    {
        private const int RechargeHeal = 5;

        private const int RechargeHitChance = 8;

        private const int RechargeCooldown = 2;

        private const string RechargeHitMessage = "The strong lightning force recharges your health!";

        private const string RechargeMissMessage = "You failed to recharge!";

        protected Recharge()
            : base(AbilityType.Battle, RechargeHitChance,
            RechargeCooldown, RechargeHitMessage, RechargeMissMessage)
        {
            this.Heal = RechargeHeal;
        }

        public int Heal { get; private set; }
    }
}