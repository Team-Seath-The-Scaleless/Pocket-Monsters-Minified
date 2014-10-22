namespace Abilities
{
    using Interfaces;

    public abstract class HealAbility : SpecialAbility, IHealingAbility
    {
         protected HealAbility(int abilityPower, AbilityType type, int hitChance,
            int baseCooldown, int currentCooldown, string hitMsg, string missMsg)
            : base(abilityPower, type, hitChance, baseCooldown, currentCooldown, hitMsg, missMsg)
         { 
         }
        
         public void Heal(IPokemon target)
         {
             target.CurrentHealth += this.AbilityPower;
             if (target.CurrentHealth > target.MaxHealth)
             {
                 target.CurrentHealth = target.MaxHealth;
             }
         }
    }
}
