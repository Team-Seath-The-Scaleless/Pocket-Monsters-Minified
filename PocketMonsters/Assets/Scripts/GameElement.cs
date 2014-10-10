using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class GameElement : MonoBehaviour
    {
        public float PositionX { get; protected set; }

        public float PositionY { get { return 0.0F; } }

        public float PositionZ { get; protected set; }
    }
}
