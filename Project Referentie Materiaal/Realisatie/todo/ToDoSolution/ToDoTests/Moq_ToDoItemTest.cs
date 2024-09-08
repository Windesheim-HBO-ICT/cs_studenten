using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ToDo;

namespace ToDoTests
{
    public class Moq_ToDoItemTest
    {
        private readonly IToDoItemRepository itemRepositoryMock;

        public Moq_ToDoItemTest()
        {
            //Seting up the data access layer thats being mocked

            //Creating the ToDo items for test data, replacing database data
            var toDoItems = new List<ToDoItem>();
            toDoItems.Add(new ToDoItem("Coding C#", ToDoState.Active) { Due = DateTime.Now.AddHours(24)});
            toDoItems.Add(new ToDoItem("Coding C++", ToDoState.Suspended) { Due = DateTime.Now.AddDays(364)});
            toDoItems.Add(new ToDoItem("Coding PHP", ToDoState.Completed) { Due = DateTime.Now.AddDays(-364)});

            //Setting up Moq to inform the interface to be mocked
            Mock<IToDoItemRepository> mock = new Mock<IToDoItemRepository>();

            //Mocking IToDoItemRepository.Insert method
            mock.Setup<int>(mock => mock.Insert(It.IsAny<ToDoItem>())).Returns((ToDoItem toDoItem) =>
            {
                toDoItem.Id = toDoItems.Max(i => i.Id) + 1;
                toDoItems.Add(toDoItem);
                return toDoItem.Id;
            });

            //Mocking IToDoItemRepository.GetAll() method
            mock.Setup<ICollection<ToDoItem>>(mock => mock.GetAll()).Returns(() =>
            {
                return toDoItems;
            });

            //Assigning the mock to the data access layer interface
            itemRepositoryMock = mock.Object;
        }


        [Fact]
        public void OverdueDue_ThrowsException()
        {  
            var toDoItem = new ToDoItem("Dued") { Due = DateTime.Now.AddDays(-1) };
            ToDoService service = new ToDoService(itemRepositoryMock);

            Assert.Throws<InvalidOperationException>(() => { service.CreateNewToDoItem(toDoItem); });
        }
    }
}
