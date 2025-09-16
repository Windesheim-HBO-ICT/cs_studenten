using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.App.ViewModels
{
    public abstract class ViewModel: INotifyPropertyChanged
    {
        public string Title { get; set; } = string.Empty;


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string property) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


        public virtual void Load() { }
        public virtual void OnAppearing() { }
        public virtual void OnDisappearing() { }

    }
}
