using System;

namespace Assets.Scripts.Items
{
    class AppleFoodItem : FoodItemsHealth
    {

        public override int GiveHealth
        {
            get { return 35; }
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
