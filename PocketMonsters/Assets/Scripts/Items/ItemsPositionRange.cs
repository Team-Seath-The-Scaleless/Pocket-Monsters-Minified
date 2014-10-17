using System;

namespace Items
{
    public class ItemsPositionRange
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

            set { this.startRange = value; }
        }

        public int EndRange
        {
            get { return this.endRange; }

            set
            {
                if (this.startRange > value)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.endRange = 1;
            }
        }
    }
}
