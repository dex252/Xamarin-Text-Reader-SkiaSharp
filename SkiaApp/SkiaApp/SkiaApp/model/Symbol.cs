using SkiaSharp;
using System.Collections.Generic;

namespace SkiaApp.model
{
    public class Symbol
    {
        List<IFragments> items = new List<IFragments>();

        public Symbol(Symbol value)
        {
            foreach(IFragments fragment in value.items)
            {
                IShape copy = fragment.GetFragment();

                if (copy.GetType() == 1)
                {
                    var bezier = copy as Bezier;
                    Bezier Bezier = new Bezier(bezier.x.X, bezier.x.Y, bezier.y.X, bezier.y.Y, bezier.z.X, bezier.z.Y);

                    Fragment frag = new Fragment();
                    frag.SetFragment(Bezier);

                    items.Add(frag);
                }
                else if (copy.GetType() == 0)
                {
                    var line = copy as Line;
                    Line Line = new Line(line.x.X, line.x.Y, line.y.X, line.y.Y);

                    Fragment frag = new Fragment();
                    frag.SetFragment(Line);

                    items.Add(frag);
                }
                else
                {
                    var oval = copy as Oval;
                    Oval Oval = new Oval(oval.x.X, oval.x.Y, oval.rx, oval.ry);

                    Fragment frag = new Fragment();
                    frag.SetFragment(Oval);

                    items.Add(frag);
                }
            }
        }
        public Symbol()
        {

        }
        public void SetItems(List<IFragments> items)
        {
            this.items = items;
        }

        public void Draw(SKCanvas canvas, SKPaint paint, int posH, int PosV)
        {
            foreach(IFragments fragment in items)
            {
                IShape item = fragment.GetFragment();
                item.UpdatePoints(posH, PosV);

                int type = item.GetType();
                
                if (type == 1)
                {
                    Bezier bezier = item as Bezier;

                    SKPath path = new SKPath();
                    path.MoveTo(bezier.x);

                    path.CubicTo(bezier.x, bezier.y, bezier.z);

                    canvas.DrawPath(path, paint);

                }
                else if (type == 0)
                {
                    Line line = item as Line;

                    canvas.DrawLine(line.x, line.y, paint);
                }
                else
                {
                    Oval oval = item as Oval;

                    canvas.DrawOval(oval.x.X, oval.x.Y, oval.rx, oval.ry, paint);
                }
            }
        }
    }
}
