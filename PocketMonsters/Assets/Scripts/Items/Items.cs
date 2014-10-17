namespace Items
{
    public abstract class Items
    {
        public ItemCoordinatesGenerator Coordinates { get; set; }

        public abstract void Draw();
    }
}
