using System;

namespace Abilities
{
    public class NormalAttack : Ability
    {
       public NormalAttack(int damage)
            : base(AbilityType.Battle)
        {
            this.Damage = damage;
        }

        public int Damage { get; private set; }
    }
}
