namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Interfaces;

    public class FriendlyNpc : Npc, ITalkable
    {
        private readonly string[] defaultDialogue = { "Hello", "How are you today" };

        public FriendlyNpc(string[] dialogueLines = null)
            : base(dialogueLines)
        {
            if (this.DialogueLines == null)
            {
                this.DialogueLines = this.defaultDialogue;
            }
        }
    }
}
