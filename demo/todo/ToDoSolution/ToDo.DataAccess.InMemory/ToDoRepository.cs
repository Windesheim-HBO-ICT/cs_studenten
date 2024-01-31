using ToDo;

namespace ToDo.DataAccess.InMemory
{
    public class ToDoRepository : IToDoItemRepository
    {
        private ICollection<ToDoItem> _items;

        public ToDoRepository()
        {
            _items = new List<ToDoItem>() { 
                new ToDoItem("Sample ToDo Item 1", ToDoState.Undetermined){ Id = 1 },
                new ToDoItem("Sample ToDo Item 2", ToDoState.Active) { Id = 2 },
                new ToDoItem("Sample ToDo Item 3", ToDoState.Suspended){ Id = 3 },
                new ToDoItem("Sample ToDo Item 4", ToDoState.Completed) { Id = 4 }
            };
        }

        public ICollection<ToDoItem> GetAll()
        {
            return _items;
        }

        public int Insert(ToDoItem newToDoItem)
        {
            var newId = _items.Max(i => i.Id) + 1;
            newToDoItem.Id = newId;
            _items.Add(newToDoItem);
            return newId;
        }
    }
}
