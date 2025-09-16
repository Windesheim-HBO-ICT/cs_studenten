using PeopleManager.Core.Data.Models;
using PeopleManager.Core.Models;
using PeopleManager.Core.Repositories;
using SQLite;

namespace PeopleManager.Core.Data
{
    public class PeopleSqliteRepository: IPeopleRepository
    {
        private string _dbPath;
        private SQLiteConnection? connection;
        public PeopleSqliteRepository(string dbpath)
        {
            connection = null;

            StatusMessage= string.Empty;

            _dbPath = dbpath;
        }

        public string StatusMessage { get; set; } 
        public void Init()
        {
            if (connection is not null)
            {
                return;
            }

            connection = new SQLiteConnection(_dbPath);

            connection.CreateTable<PersonData>();

            if (connection.Table<PersonData>().Count() == 0)
            {
                //For demonstration purposes, always have people in db:
                List<PersonData> people = new ()
                {
                    new () { Id = 1, FirstName = "Jeane", LastName = "Jeaneson", DateOfBirth = (new DateOnly(1999, 1, 1)).ToShortDateString() },
                    new () { Id = 2, FirstName = "Nieck", LastName = "Nieckolson", DateOfBirth = (new DateOnly(2000, 2, 2)).ToShortDateString() },
                    new () { Id = 3, FirstName = "Mearie", LastName = "Meariession", DateOfBirth = (new DateOnly(2001, 3, 3)).ToShortDateString() }
                };
                connection.InsertAll(people);
            }
        }


        public Person? GetById(int id)
        {
            Init();

            PersonData personData = new PersonData();
            try
            {
                personData = connection.Table<PersonData>().FirstOrDefault(p => p.Id == id);
                StatusMessage = $"Success, get person with Id {id};";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to get person with Id {id}. Reason: {ex.Message}";                
            }
            return PersonDataToPerson(personData);
        }

        public List<Person> GetAll()
        {
            Init();

            List<PersonData> peopleData = new List<PersonData>();

            try 
            {
                peopleData = connection.Table<PersonData>().ToList();
                this.StatusMessage = "Success, get all people.";
            }
            catch (Exception ex) 
            {
                this.StatusMessage = $"Failed to get all people. Reason: {ex.Message}";            
            }
            return PeopleDataToPeople(peopleData);
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }

        public static PersonData PersonToPersonData(Person person) 
        {
            if (person is null)
            {
                return null;
            }
            return new PersonData()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName= person.LastName,
                DateOfBirth= person.DateOfBirth.ToShortDateString(),
            };
        }
        public static Person PersonDataToPerson(PersonData personData)
        {
            if (personData is null)
            {
                return null;
            }
            return new Person()
            {
                Id = personData.Id,
                FirstName = personData.FirstName,
                LastName = personData.LastName,
                DateOfBirth = DateOnly.Parse(personData.DateOfBirth),
            };
        }

        public static List<Person> PeopleDataToPeople(ICollection<PersonData> peopleData) 
        {
            return peopleData.Select(p => PersonDataToPerson(p)).ToList();
        }
        public static List<PersonData> PeopleToPeopleData(ICollection<Person> people) 
        {
            return people.Select(p => PersonToPersonData(p)).ToList();
        }

    }
}
