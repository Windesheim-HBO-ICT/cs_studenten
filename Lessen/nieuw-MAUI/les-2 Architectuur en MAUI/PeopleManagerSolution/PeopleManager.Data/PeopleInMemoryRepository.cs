using PeopleManager.Core.Models;
using PeopleManager.Core.Repositories;

namespace PeopleManager.Core.Data
{
    public class PeopleInMemoryRepository : IPeopleRepository
    {
        List<Person> people= new List<Person>() {
            new Person() { Id=1, FirstName="Jane", LastName="Janeson", DateOfBirth=new DateOnly(1999,1,1)},
            new Person() { Id=2, FirstName="Nick", LastName="Nickolson", DateOfBirth=new DateOnly(2000,2,2) },
            new Person() { Id=3, FirstName="Marie", LastName="Mariession", DateOfBirth=new DateOnly(2001,3,3)}
        };

        public List<Person> GetAll()
        {
            return people;
        }

        public Person? GetById(int id)
        {
            return people.FirstOrDefault(p =>p.Id==id);
        }

        public void Update(Person person)
        {
            var personToUpdate = people.Single(p => p.Id == person.Id);
            personToUpdate.FirstName = person.FirstName;
            personToUpdate.LastName = person.LastName;
            personToUpdate.DateOfBirth = person.DateOfBirth;
        }
    }
}
