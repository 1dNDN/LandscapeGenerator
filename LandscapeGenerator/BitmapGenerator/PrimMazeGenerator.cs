using System;

namespace LandscapeGenerator.BitmapGenerator
{
    internal class PrimMazeGenerator : IBitmapGenerator
    {
        private DirectBitmap bitmap;

        public PrimMazeGenerator(int height, int width)
        {
            bitmap = new DirectBitmap(width, height);
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }

        public DirectBitmap Get()
        {
            return bitmap;
        }
    }
}