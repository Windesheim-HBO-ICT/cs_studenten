using System;
using System.Collections.Generic;
using System.Linq;
using sl = Microsoft.Data.Sqlite;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ToDo.DataAccess.SQL
{
    public static class DatabaseCreator
    {
        public static void CreateDataBaseIfNotExist(string databaseName) 
        {
            var connectionstring = $"Data Source={databaseName}.db";
            using (SqliteConnection connection = new SqliteConnection(connectionstring))
            {
                connection.Open();

                string createTableToDoItems = "CREATE TABLE ToDoItems (id INTEGER PRIMARY KEY, title VARCHAR(100) NOT NULL, description VARCHAR(500) NULL, state INT NOT NULL, due TEXT NULL";
                var createTableToDoCommand = new SqliteCommand(createTableToDoItems, connection);

                createTableToDoCommand.ExecuteNonQuery();

            }
        }
    }
}
