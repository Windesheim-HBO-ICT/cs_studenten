using PeopleViewer.Views;

namespace PeopleViewer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PersonDetailsView), typeof(PersonDetailsView));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}