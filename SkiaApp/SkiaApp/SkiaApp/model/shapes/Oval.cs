using SkiaSharp;

namespace SkiaApp.model
{
    class Oval : IShape
    {
        public SKPoint x;
        public float rx;
        public float ry;

        public Oval(float x1, float y1, float rx, float ry)
        {
            x.X = x1;
            x.Y = y1;
            this.rx = rx;
            this.ry = ry;
        }
        public void UpdatePoints(int posH, int PosV)
        {
            x.X = x.X + posH * App.SymbolIntervalHorizontal;

            x.Y = x.Y + PosV * App.SymbolIntervalVertical;
        }

        int IShape.GetType()
        {
            return 2;
        }
    }
}
