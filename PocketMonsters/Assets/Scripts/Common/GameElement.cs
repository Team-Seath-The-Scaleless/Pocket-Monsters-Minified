namespace Common
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class GameElement
    {
		private float positionY;

		private float positionX;

		private float positionZ;

		public float PositionX
		{
			get{
				return this.positionX;
			}
			protected set{
				this.positionX = value;
			}
		}

        public float PositionY 
		{ 
			get 
			{ return 1F; 
			} 
			set{
				this.positionY = value;
						}
		}

        public float PositionZ 
		{
			get{
				return this.positionZ;
			}
			protected set{
				this.positionZ = value;
			}
		}

    }
}
