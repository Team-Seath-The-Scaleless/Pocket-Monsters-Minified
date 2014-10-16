using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
//using UnityEngine;
using Common;
using Creatures;

namespace Assets.Scripts.Creatures
{

    class NpcFoodItems : GameElement
    {
        private float positionX;
        private float positionY;
        private float positionZ;
        public new float PositionX 
        {
            get { return this.positionX; }
            set { this.positionX = FoodItemPositionGenerator(); } 
        }

        public float PositionY { get { return 0.0F; } }

        public new float PositionZ 
        {
            get { return this.positionZ; }
            set { this.positionY = FoodItemPositionGenerator(); }
        }
        
        public float FoodItemPositionGenerator() 
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            double value = rnd.NextDouble();
            float result = (float)(number + Math.Round(value, 2));
            return result;
        }
        
    }
}
