using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Abilities
{
	public abstract class HealAbility : SpecialAbility, IHealingAbility
    {
         public int Heal { get; set; }
         public HealAbility(AbilityType type, int hitChance,
            int cooldown, string hitMsg, string missMsg, int heal)
            : base(type, hitChance, cooldown, hitMsg, missMsg)
        {
            this.Heal = heal;
        }
    }
}
