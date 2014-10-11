using System;

namespace Abilities
{
    public abstract class SpecialAbility : Ability
    {
        protected SpecialAbility(AbilityType type)
            : base(type)
        {
        }
    }
}
