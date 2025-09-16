using PeopleManager.Core.Models;
using PeopleManager.Core.Repositories;

namespace PeopleManager.Core.Services
{
    public class PeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public Person? GetPersonById(int id) 
        {
            if (id <= 0) return null;

            return _peopleRepository.GetById(id);
        }

        public ICollection<Person> GetAllPeople() 
        {
            return _peopleRepository.GetAll();
        }
    }
}
