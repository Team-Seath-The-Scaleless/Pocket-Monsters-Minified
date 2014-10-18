namespace Abilities
{
    using System;

    using Interfaces;

    public class Iceblade : DamageAbility
    {
        private const int IcebladeDamage = 5;

        private const int IcebladeHitChance = 9;

        private const int IcebladeCooldown = 1;

        private const string IcebladeHitMessage = "A huge blade of ice slams the enemy!";

        private const string IcebladeMissMessage = "Iceblade failed to hit!";

        public Iceblade()
            : base(AbilityType.Frost, IcebladeHitChance,
            IcebladeCooldown, IcebladeHitMessage, IcebladeMissMessage, IcebladeDamage)
        {

        }
    }
}