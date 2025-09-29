using PeopleViewer.Views;

namespace PeopleViewer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PersonDetailsView), typeof(PersonDetailsView));
        }
    }
}
