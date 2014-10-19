namespace Abilities
{
    using System;
    using Interfaces;

    public class IceBlade : DamageAbility
    {
        private const int IceBladeDamage = 5;
        private const int IceBladeHitChance = 9;
        private const int IceBladeCooldown = 1;
        private const string IceBladeHitMessage = "A huge blade of ice slams the enemy!";
        private const string IceBladeMissMessage = "Iceblade failed to hit!";

        public IceBlade()
            : base(IceBladeDamage, AbilityType.Frost, IceBladeHitChance, IceBladeCooldown,
            IceBladeHitMessage, IceBladeMissMessage)
        { }
    }
}