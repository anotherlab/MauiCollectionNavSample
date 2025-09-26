using MauiCollectionNavSample.Views;

namespace MauiCollectionNavSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("DetailPage", typeof(DetailPage));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}