using SkiaSharp;

namespace SkiaApp.model
{
    class Bezier: IShape
    {
        public SKPoint x;
        public SKPoint y;
        public SKPoint z;

        public Bezier(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            x.X = x1;
            x.Y = y1;
            y.X = x2;
            y.Y = y2;
            z.X = x3;
            z.Y = y3;
        }

        public void UpdatePoints(int posH, int PosV)
        {
            x.X = x.X + posH * App.SymbolIntervalHorizontal;
            y.X = y.X + posH * App.SymbolIntervalHorizontal;
            z.X = z.X + posH * App.SymbolIntervalHorizontal;

            x.Y = x.Y + PosV * App.SymbolIntervalVertical;
            y.Y = y.Y + PosV * App.SymbolIntervalVertical;
            z.Y = z.Y + PosV * App.SymbolIntervalVertical;
        }

        int IShape.GetType()
        {
            return 1;
        }
    }
}
