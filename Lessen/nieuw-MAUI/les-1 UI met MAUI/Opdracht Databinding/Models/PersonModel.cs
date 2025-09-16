using System.ComponentModel;

namespace Models
{
    public class PersonModel: INotifyPropertyChanged
    {

		private string name = string.Empty;

		public string Name
		{
			get { return name; }
			set { 
				
				name = value; 
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
			}
		}


		public event PropertyChangedEventHandler? PropertyChanged;
    }
}
