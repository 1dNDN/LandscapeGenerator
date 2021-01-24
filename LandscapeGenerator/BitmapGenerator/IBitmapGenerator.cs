namespace LandscapeGenerator.BitmapGenerator
{
    public interface IBitmapGenerator
    {
        public void Tick();
        public DirectBitmap Get();
    }
}