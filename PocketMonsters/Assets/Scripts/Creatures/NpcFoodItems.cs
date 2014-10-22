namespace Creatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using UnityEngine;
    using Common;
    using Creatures;

    public class NpcFoodItems : GameElement
    {
        public float FoodItemPositionGenerator() 
        {
            System.Random rnd = new System.Random();
            int number = rnd.Next(0, 100);
            double value = rnd.NextDouble();
            float result = (float)(number + Math.Round(value, 2));
            return result;
        }
    }
}
