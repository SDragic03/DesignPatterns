using System.Collections.Generic;
using RepositoryPattern.Services;

namespace RepositoryPattern.Repositories
{
    public class ServiceRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPerson()
        {
            throw new System.NotImplementedException();
        }

        public Person GetPerson(string lastName)
        {
            throw new System.NotImplementedException();
        }
    }
}