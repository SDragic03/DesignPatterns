using System.Collections.Generic;
using RepositoryPattern.Services;

namespace RepositoryPattern.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPerson();

        Person GetPerson(string lastName);
    }
}