namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Interfaces;

    public class EnemyNpc : Npc, IPokemonTrainer, ITalkable
    {
        public static readonly string[] DefaultDialogue = { "Here you are", "Let's fight" };

        public EnemyNpc(IList<IPokemon> pokemons, string[] dialogueLines = null)
            : base(dialogueLines)
        {
            this.Pokemons = pokemons;
            if (this.DialogueLines == null)
            {
                this.DialogueLines = EnemyNpc.DefaultDialogue;
            }
        }

        public IList<IPokemon> Pokemons { get; set; }
    }
}
