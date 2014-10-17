namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using UnityEngine;
    using Common;

    public abstract class Npc : GameElement
    {
        protected Npc(string[] dialogueLines)
        {
            this.DialogueLines = dialogueLines;
        }

        public string[] DialogueLines { get; protected set; }
    }
}
