using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.WpfApp.ViewModels
{
    public abstract class BaseViewModel
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void PropertyChanging([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
