using PeopleViewer.Models;
using System.ComponentModel;

namespace PeopleViewer.ViewModels
{
    /// <summary>
    /// This viewmodel has the IQueryAttributable interface implemented.
    /// When navigating, the method IQueryAttributable.ApplyQueryAttributes method is called by the applications routing mechanism.
    /// The data from the Person route query parameter is set to data bindable properties to update the UI.
    /// </summary>

    //The view is depending on a ViewModel with name PersonDetailsViewModel
    //To use this implementation:
    // - make sure the classname in file PersonDetailsViewModel_QP.cs is PersonDetailsViewModel_QP
    // - make sure the classname in this file PersonDetailsViewModel_IQA.cs is PersonDetailsViewModel


    public class PersonDetailsViewModel_IQA : IQueryAttributable, INotifyPropertyChanged
    {

        private string firstName = string.Empty;
        private string lastname = string.Empty;
        private string dateOfBirth = string.Empty;
        private string placeOfBirth = string.Empty;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                OnPropertyChanged(nameof(DateOfBirth));
            }
        }
        public string PlaceOfBirth
        {
            get { return placeOfBirth; }
            set
            {
                placeOfBirth = value;
                OnPropertyChanged(nameof(PlaceOfBirth));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Person person = query["PersonParameter"] as Person ?? new Person();
            this.FirstName = person.FirstName;
            this.Lastname = person.Lastname;
            this.DateOfBirth = person.DateOfBirth != new DateOnly() ? person.DateOfBirth.ToShortDateString() : "-";
            this.PlaceOfBirth = person.PlaceOfBirth;
        }
    }
}
