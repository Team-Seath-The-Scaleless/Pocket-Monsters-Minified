namespace Items
{
    using System;

    public class ItemCoordinatesGenerator : ItemsPositionRange
    {
        private readonly Random randomGenerator = new Random();

        private float x;
        private float z;

        public ItemCoordinatesGenerator(int startRange, int endRange, float x = 0, float z = 0)
            : base(startRange, endRange)
        {
            this.X = x;
            this.Z = z;
        }

        public float X
        {
            get
            {
                return (float)Math.Round(this.x, 2);
            }

            set
            {
                // WTF - the value is never used, check it pls
                //this.x = (float)(this.randomGenerator.Next(base.StartRange, base.EndRange) + this.randomGenerator.NextDouble());
                this.x = value;
            }
        }

        public float Y
        {
            get { return 1F; }
        }

        public float Z
        {
            get
            {
                return (float)Math.Round(this.z, 2);
            }

            set
            {
                // WTF - the value is never used, check it pls
                //this.z = (float)(this.randomGenerator.Next(base.StartRange, base.EndRange) + this.randomGenerator.NextDouble());
                this.z = value;
            }
        }

        public float[] ReturnCoordinates()
        {
            float[] cooridnates = { this.X, this.Z };
            return cooridnates;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.X, this.Z);
        }
    }
}
