using PeopleManager.App.ViewModels;
using PeopleManager.Core.Data;

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