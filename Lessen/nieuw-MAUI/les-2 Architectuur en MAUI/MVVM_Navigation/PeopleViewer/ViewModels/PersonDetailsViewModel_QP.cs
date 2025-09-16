using PeopleViewer.Models;
using System.ComponentModel;

namespace PeopleViewer.ViewModels
{
    /// <summary>
    /// This viewmodel has the [QueryProperty] attribute applied.
    /// When navigating, the applications routing mechanism sets the PersonProperty with the value retrieved from the query by the PersonParameter key.
    /// The data from the Person route query parameter is set by the applications routing mechanism to the PersonProperty which sets the data bindable properties to update the UI.
    /// </summary>

    //The view is depending on a ViewModel with name PersonDetailsViewModel
    //To use this class implementation:
    // - make sure the classname in this file PersonDetailsViewModel_QP.cs is PersonDetailsViewModel
    // - make sure the classname in file PersonDetailsViewModel_IQA.cs is PersonDetailsViewModel_IQA

    [QueryProperty("PersonProperty", "PersonParameter")]
    public class PersonDetailsViewModel : INotifyPropertyChanged
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


        /// <summary>
        /// Note:
        /// If Person class were a ViewModel with the INotifyPropertyChanged interface implemented,
        /// the view would be able to data bind directly to the Person properties to update the UI
        /// </summary>
        public Person PersonProperty
        {
            set { 
                this.FirstName = value.FirstName;
                this.Lastname = value.Lastname;
                this.DateOfBirth = value.DateOfBirth != new DateOnly() ? value.DateOfBirth.ToShortDateString() : "-";
                this.PlaceOfBirth = value.PlaceOfBirth;
            }
        }

    }
}
