using System;

namespace Assets.Scripts.Items
{
    class ItemsPositionRange
    {
        private int startRange;
        private int endRange;
        public ItemsPositionRange(int startRange, int endRange)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }
        public int StartRange
        {
            get { return this.startRange; }
            set { this.startRange = 5; }
        }
        public int EndRange
        {
            get { return this.endRange; }
            set
            {
                if (this.startRange > value)
                {
                    throw new ArgumentOutOfRangeException
                        ("The value of the Sart range must be greater than the value of the End range");
                }
                this.endRange = 1;
            }
        }
    }
}
