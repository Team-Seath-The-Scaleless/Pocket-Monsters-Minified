namespace Abilities
{
    using System;

    public class Armageddon : SpecialAbility
    {
        public const int ArmageddonDamage = 15; 

        public const int ArmageddonHitChance = 3;

        public const int ArmageddonCooldown = 4;

        public const string ArmageddonHitMessage = "The unstopable flames burn everything around!";

        public const string ArmageddonMissMessage = "Summoning Armageddon failed!";

        protected Armageddon()
            : base()
        {
            this.ArmageddonHit = this.TargetIsHit();
        }

        public bool ArmageddonHit { get; private set; }
    }
}