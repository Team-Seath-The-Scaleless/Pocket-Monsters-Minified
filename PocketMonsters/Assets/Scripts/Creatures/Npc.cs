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
        private GameObject npc;

        protected Npc(GameObject objectOnField, string[] dialogueLines)
        {
            this.NpcObject = objectOnField;
            this.DialogueLines = dialogueLines;
        }

        public GameObject NpcObject
        {
            get { return this.npc; }
            private set { this.npc = value; }
        }

        public string[] DialogueLines { get; protected set; }
    }
}
