namespace Abilities
{
    using System;
    using Interfaces;

    public class SuperNova : DamageAbility
    {
        private const int SuperNovaDamage = 16;
        private const int SuperNovaHitChance = 5;
        private const int SuperNovaCooldown = 4;
        private const string SuperNovaHitMessage = "The Supernova released the ultimate force!";
        private const string SuperNovaMissMessage = "Supernova has missed the target!";

        public SuperNova()
            : base(SuperNovaDamage, AbilityType.Lightning, SuperNovaHitChance, SuperNovaCooldown,
            SuperNovaHitMessage, SuperNovaMissMessage)
        { }
    }
}