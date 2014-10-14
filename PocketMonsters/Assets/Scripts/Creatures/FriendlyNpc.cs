namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Interfaces;

    public class FriendlyNpc : Npc, ITalkable
    {
        public static readonly string[] DefaultDialogue = { "Hello", "How are you today" };

        public FriendlyNpc(string[] dialogueLines = null)
            : base(dialogueLines)
        {
            if (this.DialogueLines == null)
            {
                this.DialogueLines = FriendlyNpc.DefaultDialogue;
            }
        }
    }
}
