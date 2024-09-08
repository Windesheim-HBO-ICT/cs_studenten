using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Validation
{
    public class ToDoItemValidator
    {
        public const string AlreadyDue = "A new due for a ToDo item cannot already be due. The date for due is in the past. Enter a future date.";
        public const string EmptyTitle = "A Todo item must have a title. The Title is empty. Enter a title.";
        public const string NotAssigned = "A ToDo item should be assigned to. Assigned to is empty. Enter a name to assign this ToDo item.";
        public bool ValidateNewDue(DateTime newDue) 
        {
            if (newDue < DateTime.Now)
                throw new InvalidOperationException(AlreadyDue);

            return true;
        }

        public bool ValidateAssignedTo(string assignedTo) 
        {
            if (string.IsNullOrWhiteSpace(assignedTo))
                throw new InvalidOperationException("Todo-items need to be assigned to someone.");

            return true;
        }
        public bool ValidateTitle(string title) 
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new InvalidOperationException("Todo-items require a title.");

            return true;
        }
    }
}
