using PersonEditor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonEditor.ViewModel
{
    public class CreatePersonViewModel: INotifyPropertyChanged
    {
		private string _firstName = string.Empty;
		private string _lastname = string.Empty;
		private string _state = string.Empty;

		private const string NewState = "New";
		private const string SavedState = "Saved";

		public string FirstName
		{
			get { return _firstName; }
			set { 
				_firstName = value;
				OnPropertyChanged(nameof(FirstName));
				State = NewState;
			}
		}

		public string Lastname
		{
			get { return _lastname; }
			set { 				
				_lastname = value;
				OnPropertyChanged(nameof(Lastname));
				State = NewState;
			}
		}

        public event PropertyChangedEventHandler? PropertyChanged;

		public void OnPropertyChanged(string propertyName) 
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public string State
		{
			get { return _state; }
			private set { 
				_state = value; 
				OnPropertyChanged(nameof(State));
                ((Command)SaveNewPersonCommand).ChangeCanExecute();
            }
		}
		public ICommand SaveNewPersonCommand { get; private set; }

        public CreatePersonViewModel()
        {
            SaveNewPersonCommand = new Command(SaveNewPerson, CanSaveNewPerson);
        }

		private bool CanSaveNewPerson() 
		{
			return Person.HasNoEmptyName(FirstName, Lastname);
		}
        public void SaveNewPerson() 
		{
			Person newPerson = new Person();
			newPerson.FirstName = FirstName;
			newPerson.LastName = Lastname;

            //Code to have person data validated and stored has been omitted.
			//_personDataProvider.SaveNewPerson(newPerson)

            FirstName = string.Empty;
			Lastname = string.Empty;
			State = SavedState;
		}

    }
}
