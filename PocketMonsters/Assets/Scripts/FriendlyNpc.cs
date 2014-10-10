using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class FriendlyNpc : Creature, ITalkable
    {
        public static readonly string[] DefaultDialogue = { "Hello", "How are you today" };

        public string[] DialogueLines { get; private set; }
    }
}
