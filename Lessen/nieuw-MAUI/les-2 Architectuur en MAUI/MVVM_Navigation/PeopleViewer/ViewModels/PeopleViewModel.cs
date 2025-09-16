using PeopleViewer.Models;
using PeopleViewer.Services;
using PeopleViewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PeopleViewer.ViewModels
{
    public class PeopleViewModel 
    {
        public IEnumerable<Person> People { get; set; }

        public PeopleViewModel()
        {
            People = new PeopleService().GetAllPeople();
            SelectionChangedCommand = new Command(OnSelectionChanged);
        }

        public ICommand SelectionChangedCommand { get; }

        private async void OnSelectionChanged(object person) 
        {
            if(person is not null && person is Person)
            {
                Person p = (Person)person;
                Dictionary<string, object> parameter = new() { { "PersonParameter", p } };
                await Shell.Current.GoToAsync($"{nameof(Views.PersonDetailsView)}", parameter);
            }
        }
    }
}
