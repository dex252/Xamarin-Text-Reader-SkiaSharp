using System.ComponentModel;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System.Collections.Generic;
using SkiaApp.model;
using System.IO;
using SkiaApp.Data;

namespace SkiaApp
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Dictionary<char, Symbol> dictionary = new Dictionary<char, Symbol>();

        public MainPage()
        {
            GetDictionaryAsync();
            InitializeComponent();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
        }

        private void GetDictionaryAsync()
        {
            DataSeter DataSeter = new DataSeter();
            for (int i = 'а'; i <= 'я'; i++)
            {
                dictionary.Add((char)i, DataSeter.GetSym(char.ToUpper((char)i)));
            }

            dictionary.Add(' ', DataSeter.GetSym(' '));
            dictionary.Add(',', DataSeter.GetSym(','));
            dictionary.Add('.', DataSeter.GetSym('.'));
            dictionary.Add('?', DataSeter.GetSym('?'));
            dictionary.Add('!', DataSeter.GetSym('!'));
        }

        SKPaint paint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            Color = SKColors.MediumPurple,
            StrokeWidth = 6,
            StrokeCap = SKStrokeCap.Round,
            StrokeJoin = SKStrokeJoin.Round,
        };

        public void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            if (entry.Text!=null)
            {
                List<Symbol> list = new List<Symbol>();
                int posH = 0;
                int PosV = 0;

                foreach (char symbol in entry.Text)
                {
                    Symbol value = null;
                    dictionary.TryGetValue(char.ToLower(symbol), out value);
                 
                    if (value != null)
                    {
                        list.Add(new Symbol(value));
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Draw(canvas, paint, posH, PosV);
                    posH++;
                    if (posH > 11)
                    {
                        posH = 0;
                        PosV++;
                    }
                }
            }

        }
        
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            canvasView.InvalidateSurface();
        }

    }
}
