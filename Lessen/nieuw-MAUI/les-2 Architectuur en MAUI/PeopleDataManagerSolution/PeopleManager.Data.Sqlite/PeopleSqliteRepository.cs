using PeopleManager.Core.Models;
using PeopleManager.Core.Repositories;
using Microsoft.Data.Sqlite;

namespace PeopleManager.Data.Sqlite
{
    public class PeopleSqliteRepository: IPeopleRepository
    {
        private readonly string connectionString;
        public PeopleSqliteRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InitDatabase()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string createPeopleTable = @"
                    CREATE TABLE IF NOT EXISTS People (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        Lastname TEXT NOT NULL,
                        DateOfBirth TEXT NOT NULL
                    );";

                using (var command = new SqliteCommand(createPeopleTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                Int64 amountOfPeople = 0;
                string countPeople = @"SELECT COUNT(*) FROM People;";
                using (var command = new SqliteCommand(countPeople, connection))
                {
                    amountOfPeople = (Int64)command.ExecuteScalar();
                }

                if (amountOfPeople == 0)
                {
                    string addPeople = @"
                        INSERT INTO People (FirstName, Lastname, DateOfBirth) VALUES ('Jeane','Jeanesen','1999-1-1');
                        INSERT INTO People (FirstName, Lastname, DateOfBirth) VALUES ('Nieck','Nieckolson','2000-2-2');
                        INSERT INTO People (FirstName, Lastname, DateOfBirth) VALUES ('Maerie','Maeriession','2001-3-3');";

                    using (var command = new SqliteCommand(addPeople, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
        }
        public List<Person> GetAll()
        {
            InitDatabase();

            var people = new List<Person>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string selectAllPeople = @"SELECT Id, FirstName, Lastname, DateOfBirth FROM People;";

                using (var command = new SqliteCommand(selectAllPeople, connection))
                {
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var person = new Person();
                        person.Id = dataReader.GetInt32(0);
                        person.FirstName = dataReader.GetString(1);
                        person.LastName = dataReader.GetString(2);
                        person.DateOfBirth = DateOnly.Parse(dataReader.GetString(3));

                        people.Add(person);
                    }
                }
            }
            return people;
        }

        public Person? GetById(int id)
        {
            Person? person = null;
            using (var connection = new SqliteConnection(connectionString))
            {
                string findPersonById = @"
                    SELECT Id, FirstName, Lastname, DateOfBirth FROM People WHERE Id=@Id";
                connection.Open();
                using (var command = new SqliteCommand(findPersonById, connection))
                {
                    command.Parameters.AddWithValue("Id", id);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        person = new Person();
                        person.Id = reader.GetInt32(0);
                        person.FirstName = reader.GetString(1);
                        person.LastName = reader.GetString(2);
                        person.DateOfBirth = DateOnly.Parse(reader.GetString(3));
                    }
                }
            }
            return person;
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
