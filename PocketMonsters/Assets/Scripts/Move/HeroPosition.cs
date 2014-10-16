using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Interfaces;

namespace Assets.Scripts.Move
{  
    public abstract class HeroPosition // : IMovable
    {
        public int StartPosition { get; set; }
        public int CurrentPosition { get; set; }
    }
}
