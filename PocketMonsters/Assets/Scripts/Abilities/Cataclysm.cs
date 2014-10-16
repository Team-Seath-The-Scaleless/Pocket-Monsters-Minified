namespace Abilities
{
    using System;

    using Interfaces;

    public class Cataclysm : SpecialAbility, IDamageAbility
    {
        private const int CataclysmDamage = 100; // if pokemon max health = ~20/30.

        private const int CataclysmHitChance = 1;

        private const int CataclysmCooldown = 5;

        private const string CataclysmHitMessage = "A massive hole from the ground devours enemy unit!";

        private const string CataclysmMissMessage = "Cataclysm has failed to begin!";

        public Cataclysm()
            : base(AbilityType.Battle, CataclysmHitChance,
            CataclysmCooldown, CataclysmHitMessage, CataclysmMissMessage)
        {
            this.Damage = CataclysmDamage;
        }

        public int Damage { get; private set; }
    }
}