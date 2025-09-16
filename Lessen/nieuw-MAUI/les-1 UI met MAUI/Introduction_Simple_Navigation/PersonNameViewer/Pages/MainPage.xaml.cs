namespace PersonNameViewer.Pages
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateClicked(object? sender, EventArgs e)
        {
            string firstName = FirstNameEntry.Text;
            await Shell.Current.GoToAsync($"/subpage?firstname={firstName}");
        }
    }
}
