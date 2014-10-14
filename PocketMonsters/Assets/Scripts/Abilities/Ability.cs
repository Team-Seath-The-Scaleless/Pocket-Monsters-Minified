namespace Abilities
{
    using System;

    using Interfaces;

    public abstract class Ability : IAbility
    {
        protected Ability(AbilityType type)
        {
            this.Type = type;
        }

        public AbilityType Type { get; protected set; }
    }
}
