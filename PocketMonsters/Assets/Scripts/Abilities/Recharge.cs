namespace Abilities
{
    using System;

    using Interfaces;

    public class Recharge : SpecialAbility, IHealingAbility
    {
        private const int RechargeHeal = 8;

        private const int RechargeHitChance = 8;

        private const int RechargeCooldown = 3;

        private const string RechargeHitMessage = "The strong lightning force recharges your health!";

        private const string RechargeMissMessage = "You failed to recharge!";

        public Recharge()
            : base(AbilityType.Lightning, RechargeHitChance,
            RechargeCooldown, RechargeHitMessage, RechargeMissMessage)
        {
            this.Heal = RechargeHeal;
        }

        public int Heal { get; private set; }
    }
}