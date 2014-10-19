using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Abilities
{
    public abstract class DamageAbility : SpecialAbility, IDamageAbility
    {
        public DamageAbility(int abilityPower, AbilityType type, int hitChance,
            int cooldown, string hitMsg, string missMsg)
            : base(abilityPower, type, hitChance, cooldown, hitMsg, missMsg)
        { }

        public void Hit(IPokemon target)
        {
            target.CurrentHealth -= this.AbilityPower;
        }
    }
}
