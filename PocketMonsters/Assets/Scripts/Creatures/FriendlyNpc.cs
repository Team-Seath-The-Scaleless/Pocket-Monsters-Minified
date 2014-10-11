using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Interfaces;

namespace Creatures
{
    public class FriendlyNpc : Npc, ITalkable
    {
        public static readonly string[] DefaultDialogue = { "Hello", "How are you today" };

        public string[] DialogueLines { get; private set; }
    }
}
