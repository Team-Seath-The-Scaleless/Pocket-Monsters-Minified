using System;

namespace Interfaces
{
    public interface IHealingAbility : IAbility
    {
        void Heal(IPokemon target);
    }
}
