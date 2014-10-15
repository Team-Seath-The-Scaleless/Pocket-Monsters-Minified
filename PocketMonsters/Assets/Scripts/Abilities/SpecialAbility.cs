namespace Abilities
{
    using System;

    public abstract class SpecialAbility : Ability
    {
        private static readonly Random HitChanceCalculator = new Random();

        protected SpecialAbility(AbilityType type, int hitChance,
            int cooldown, string hitMsg, string missMsg)
            : base(type)
        {
            this.HitChance = hitChance;
            this.Cooldown = cooldown;
            this.HitMessage = hitMsg;
            this.MissMessage = missMsg;
        }

        public int HitChance { get; protected set; }

        public int Cooldown { get; protected set; }

        public string HitMessage { get; protected set; }

        public string MissMessage { get; protected set; }
        
        public static bool TargetIsHit(SpecialAbility ability)
        {
            int currentHitChance = SpecialAbility.HitChanceCalculator.Next(1, 11);

            return ability.HitChance >= currentHitChance;
        }
    }
}
