using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public interface IToDoItemRepository
    {
        int Insert(ToDoItem newToDoItem);
        ICollection<ToDoItem> GetAll();
    }
}
