using Microsoft.Data.SqlClient;

namespace ToDo.DataAccess.SqlServer
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        public string ConnectionString { get; set; }

        public ToDoItemRepository(string connectionstring)
        {
            ConnectionString = connectionstring;
        }
        //private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDoDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public ICollection<ToDoItem> GetAll()
        {
            var toDoItems = new List<ToDoItem>();
            string sql = "SELECT Id, Title, Description, Due, State, AssignedTo FROM ToDoItems;";

            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    
                    while (reader.Read()) 
                    {                         
                        var item = new ToDoItem();
                        item.Id = reader.GetInt32(0);
                        item.Title = reader.GetString(1);
                        item.Description = reader.GetString(2);
                        item.Due = reader.GetDateTime(3);
                        item.State = (ToDoState)reader.GetInt32(4);
                        item.AssignedTo = reader.GetString(5);
                        toDoItems.Add(item);
                    }
                    connection.Close();
                }
            }
            return toDoItems;
        }

        public int Insert(ToDoItem newToDoItem)
        {
            string sql = "INSERT INTO ToDoItems (Title, Description, Due, State, AssignedTo) VALUES (@Title, @Description, @Due, @State, @AssignedTo);";
            int recordsAffected = 0;

            using (var connection = new SqlConnection(ConnectionString)) {
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("Title", newToDoItem.Title);
                    command.Parameters.AddWithValue("Description", newToDoItem.Description);
                    command.Parameters.AddWithValue("Due", newToDoItem.Due);
                    command.Parameters.AddWithValue("State", (int)newToDoItem.State);
                    command.Parameters.AddWithValue("AssignedTo", newToDoItem.AssignedTo);

                    connection.Open();
                    recordsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }                
            }
            return recordsAffected;
        }
    }
}