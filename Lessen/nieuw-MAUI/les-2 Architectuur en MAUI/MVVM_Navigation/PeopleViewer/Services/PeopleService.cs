using PeopleViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleViewer.Services
{
    public class PeopleService
    {
        private List<Person> people = new List<Person>() { 
            new Person() {
                Id=1, 
                FirstName="Jane", 
                Lastname="Janesen", 
                DateOfBirth=new DateOnly(2001, 1,1), PlaceOfBirth="Janestown" },
            new Person() {
                Id=2,
                FirstName="Jone",
                Lastname="Jonesen",
                DateOfBirth=new DateOnly(2002, 2,2), PlaceOfBirth="Jonestown" },
            new Person() {
                Id=3,
                FirstName="June",
                Lastname="Junesen",
                DateOfBirth=new DateOnly(2002, 3,3), PlaceOfBirth="Junestown" }
        };

        public IEnumerable<Person> GetAllPeople() 
        {
            return people;
        }

        public Person? GetPersonById(int id) 
        {
            return people.FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}
