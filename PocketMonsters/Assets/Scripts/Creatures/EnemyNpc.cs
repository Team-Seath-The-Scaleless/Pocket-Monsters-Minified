namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Interfaces;

    public class EnemyNpc : Npc, IPokemonTrainer, ITalkable
    {
        private string[] defaultDialogue = { "Here you are", "Let's fight" };

        public EnemyNpc(IList<IPokemon> pokemons, string[] dialogueLines = null)
            : base(dialogueLines)
        {
            this.Pokemons = pokemons;
            if (this.DialogueLines == null)
            {
                this.DialogueLines = this.defaultDialogue;
            }
        }

        public IList<IPokemon> Pokemons { get; private set; }
    }
}
