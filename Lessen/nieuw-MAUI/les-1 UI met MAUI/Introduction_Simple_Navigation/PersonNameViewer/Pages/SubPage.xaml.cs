namespace PersonNameViewer.Pages
{


	[QueryProperty(nameof(FirstName), "firstname")]
	public partial class SubPage : ContentPage
	{
		public string FirstName
		{
			set
			{
				FirstNameLabel.Text = value;
			}
		}

		public SubPage()
		{
			InitializeComponent();
		}
	}
}