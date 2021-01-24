using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeGenerator.BitmapGenerator
{
    public interface IBitmapGenerator
    {
        public void Tick();
        public DirectBitmap Get();
    }
}
