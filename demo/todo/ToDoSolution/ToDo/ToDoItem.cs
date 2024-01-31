namespace ToDo
{
    public class ToDoItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime? Due { get; set; }

        public string AssignedTo { get; set; }
        public ToDoState State { get; set; }

        public ToDoItem() :this("New ToDo Item"){}
        public ToDoItem(string title): this(title, ToDoState.Undetermined){}

        public ToDoItem(string title, ToDoState state)
        {
            Title= title;
            State = state;
            AssignedTo = string.Empty;
        }
    }

    public enum ToDoState {
        Undetermined,
        Inactive,
        Active,
        Completed,
        Suspended
    }
}