using System;

namespace Assets.Scripts.Items
{
    class ItemCoordinatesGenerator : ItemsPositionRange
    {
        Random rnd = new Random();
        private float x;
        const int y = 1;
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
                this.x = (float)(rnd.Next(base.StartRange, base.EndRange) + rnd.NextDouble());
            }
        }
        public float Z
        {
            get
            {
                return (float)Math.Round(this.z, 2);
            }
            set
            {
                this.z = (float)(rnd.Next(base.StartRange, base.EndRange) + rnd.NextDouble());
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
