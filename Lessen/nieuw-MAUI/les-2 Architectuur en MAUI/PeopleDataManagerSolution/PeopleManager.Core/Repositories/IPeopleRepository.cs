using PeopleManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Core.Repositories
{
    public interface IPeopleRepository
    {
        Person? GetById(int id);

        List<Person> GetAll();

        void Update(Person person);
    }
}
