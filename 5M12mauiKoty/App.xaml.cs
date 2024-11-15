
namespace _5M12mauiKoty
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new Window();
            window.MinimumHeight = 800;
            window.MaximumHeight = 800;
            window.MinimumWidth = 600;
            window.MaximumWidth = 600;
            window.Title = "wykonał: rs";
            window.Page = new AppShell();
            return window;
        }
    }
}
