using PeopleManager.App.ViewModels;

namespace PeopleManager.App.Views;

public partial class PeopleView : ContentPage
{

	public PeopleView(PeopleViewModel peopleViewModel)
	{
		InitializeComponent();
//        var vm = new PeopleViewModel();

        BindingContext = peopleViewModel;
	}

}