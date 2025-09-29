using Microsoft.Extensions.DependencyInjection;
using PeopleManager.Core.Models;
using PeopleManager.Core.Services;
using System.Collections.ObjectModel;

namespace PeopleManager.App.ViewModels
{
    public class PeopleViewModel : ViewModel
    {
        private readonly PeopleService _peopleService;

        public ObservableCollection<Person> PeopleCollection { get; set; }


        public PeopleViewModel(PeopleService peopleService)
        {
            _peopleService = peopleService;
            PeopleCollection = new ObservableCollection<Person>(_peopleService.GetAllPeople());
        }

        //public PeopleViewModel()
        //{
        //    _peopleService = new PeopleService(new PeopleInMemoryRepository());
        //    //_peopleService = Application.Current.MainPage.Handler.MauiContext.Services.GetService<PeopleService>();
        //    PeopleCollection = new ObservableCollection<Person>(_peopleService.GetAllPeople());
        //}
    }
}
