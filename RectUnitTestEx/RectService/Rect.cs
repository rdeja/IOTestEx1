using System;

/// just a comment added
namespace RectService
{
    public class Rect
    {
        private int w, h;
        public Rect(int w, int h)
        {
            this.w = w;
            this.h = h;
        }
        public int Area()
        {
            return w*h;
        }

    }
}
