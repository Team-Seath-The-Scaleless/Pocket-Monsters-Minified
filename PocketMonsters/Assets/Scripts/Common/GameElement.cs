﻿namespace Common
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class GameElement
    {
        public float PositionX { get; protected set; }

        public float PositionY { get { return 1F; } }

        public float PositionZ { get; protected set; }
    }
}
