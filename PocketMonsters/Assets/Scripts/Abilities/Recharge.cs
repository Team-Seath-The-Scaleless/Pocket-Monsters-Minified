namespace Abilities
{
    using System;

    public class Recharge : SpecialAbility
    {
        public const int RechargeHeal = 5; // if pokemon max health = ~20/30.
        public const AbilityType RechargeSpellType = AbilityType.Battle;
        public const int RechargeHitChance = 8;
        bool RechargeHit;

        protected Recharge(int RechargeHeal)
            : base(RechargeSpellType, RechargeHitChance)
        {
            RechargeHit = targetHit();
        }
        // do heal method , allyCurrentHP + RechargeHeal 
    }
}