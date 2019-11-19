using Xamarin.Forms;

namespace SkiaApp
{
    public partial class App : Application
    {
        public const int SymbolIntervalHorizontal = 60;
        public const int SymbolIntervalVertical = 105;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
