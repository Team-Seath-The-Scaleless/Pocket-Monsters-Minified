namespace Abilities
{
    using System;

    public class Recharge : SpecialAbility
    {
        public const int RechargeHeal = 5; // if pokemon max health = ~20/30.

        public const int RechargeHitChance = 8;

        private bool rechargeHit;

        protected Recharge(int rechargeHeal)
            : base(AbilityType.Battle, RechargeHitChance)
        {
            this.rechargeHit = this.TargetIsHit();
        }

        // do heal method , allyCurrentHP + RechargeHeal 
    }
}