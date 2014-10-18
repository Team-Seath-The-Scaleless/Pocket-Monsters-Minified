using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Abilities
{
   public abstract class DamageAbility : SpecialAbility, IDamageAbility
    {

        public int Damage { get; private set; }
        public DamageAbility(AbilityType type, int hitChance,
            int cooldown, string hitMsg, string missMsg, int damage)
            : base(type, hitChance, cooldown, hitMsg, missMsg)
        {
            this.Damage = damage;
        }
    }
}
