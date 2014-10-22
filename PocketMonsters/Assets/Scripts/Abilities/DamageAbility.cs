namespace Abilities
{
    using Interfaces;

    public abstract class DamageAbility : SpecialAbility, IDamageAbility
    {
        protected DamageAbility(int abilityPower, AbilityType type, int hitChance,
            int baseCooldown, int currentCooldown, string hitMsg, string missMsg)
            : base(abilityPower, type, hitChance, baseCooldown, currentCooldown, hitMsg, missMsg)
        {  
        }

        public void Hit(IPokemon target)
        {
            target.CurrentHealth -= this.AbilityPower;
        }
    }
}
