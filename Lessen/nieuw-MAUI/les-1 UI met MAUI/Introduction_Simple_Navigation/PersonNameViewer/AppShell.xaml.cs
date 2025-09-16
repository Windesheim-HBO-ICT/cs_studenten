using PersonNameViewer.Pages;

namespace PersonNameViewer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("subpage", typeof(SubPage));
        }
    }
}
