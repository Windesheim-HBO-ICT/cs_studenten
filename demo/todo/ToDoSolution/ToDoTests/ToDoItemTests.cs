using ToDo;

namespace ToDoTests
{
    public class ToDoItemTests
    {
        [Fact]
        public void EmptyTitle_ThrowsException()
        {
            var toDoItem = new ToDoItem("") { 
                AssignedTo = "someone", 
                Description = "something", 
                Due = DateTime.Now.AddDays(1), 
                Id = 1, 
                State=ToDoState.Undetermined 
            };
            var todoService = new ToDoService(null);

            Assert.Throws<InvalidOperationException>(() => todoService.ValidateToDoItem(toDoItem));
        }

    }
}