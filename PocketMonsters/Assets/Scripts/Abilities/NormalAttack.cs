namespace Abilities
{
    using System;

    using Interfaces;

    public class NormalAttack : Ability, IDamageAbility
    {
       public NormalAttack(int damage)
            : base(AbilityType.Normal)
        {
            this.Damage = damage;
        }

        public int Damage { get; private set; }
    }
}
