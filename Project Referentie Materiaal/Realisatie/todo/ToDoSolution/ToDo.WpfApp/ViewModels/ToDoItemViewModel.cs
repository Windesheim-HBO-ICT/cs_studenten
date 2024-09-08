using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.WpfApp.ViewModels
{
    public class ToDoItem: BaseViewModel
    {
        
        public int Id { get; set; }


        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime? Due { get; set; }

        public string AssignedTo { get; set; }

        public int SelectedStateId { get; set; }


    }
}
