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
            dictionary.Add('а', DataSeter.GetSym('А'));
            dictionary.Add('б', DataSeter.GetSym('Б'));
            dictionary.Add('в', DataSeter.GetSym('В'));
            dictionary.Add('г', DataSeter.GetSym('Г'));
            dictionary.Add('д', DataSeter.GetSym('Д'));
            dictionary.Add('е', DataSeter.GetSym('Е'));
            dictionary.Add('ж', DataSeter.GetSym('Ж'));
            dictionary.Add('з', DataSeter.GetSym('З'));
            dictionary.Add('и', DataSeter.GetSym('И'));
            dictionary.Add('к', DataSeter.GetSym('К'));
            dictionary.Add('л', DataSeter.GetSym('Л'));
            dictionary.Add('м', DataSeter.GetSym('М'));
            dictionary.Add('н', DataSeter.GetSym('Н'));
            dictionary.Add('о', DataSeter.GetSym('О'));
            dictionary.Add('п', DataSeter.GetSym('П'));
            dictionary.Add('р', DataSeter.GetSym('Р'));
            dictionary.Add('с', DataSeter.GetSym('С'));
            dictionary.Add('т', DataSeter.GetSym('Т'));
            dictionary.Add('у', DataSeter.GetSym('У'));
            dictionary.Add('ф', DataSeter.GetSym('Ф'));
            dictionary.Add('х', DataSeter.GetSym('Х'));
            dictionary.Add('ц', DataSeter.GetSym('Ц'));
            dictionary.Add('ч', DataSeter.GetSym('Ч'));
            dictionary.Add('ш', DataSeter.GetSym('Ш'));
            dictionary.Add('ы', DataSeter.GetSym('Ы'));
            dictionary.Add('щ', DataSeter.GetSym('Щ'));
            dictionary.Add('э', DataSeter.GetSym('Э'));
            dictionary.Add('ю', DataSeter.GetSym('Ю'));
            dictionary.Add('я', DataSeter.GetSym('Я'));
            dictionary.Add('й', DataSeter.GetSym('Й'));
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
