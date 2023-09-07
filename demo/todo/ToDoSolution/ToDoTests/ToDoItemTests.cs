using ToDo;

namespace ToDoTests
{
    public class ToDoItemTests
    {
        [Fact]
        public void EmptyTitle_ThrowsException()
        {
            var toDoItem = new ToDoItem("");
            var todoService = new ToDoService(null);

            Assert.Throws<InvalidOperationException>(() => todoService.ValidateToDoItem(toDoItem));
        }

    }
}