namespace ToDo.DataAccess.SQL
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        const string _connectionString = "";
        public ToDoItemRepository(string databaseName)
        {
             DatabaseCreator.CreateDataBaseIfNotExist(databaseName);

        }

        public ICollection<ToDoItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(ToDoItem newToDoItem)
        {
            throw new NotImplementedException();
        }
    }
}