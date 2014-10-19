using System;

namespace Items
{
    public class AppleFoodItem : FoodItems
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
