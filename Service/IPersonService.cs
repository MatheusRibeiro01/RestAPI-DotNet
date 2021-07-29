using System.Collections.Generic;
using RestAPI_DotNet.Model;

namespace RestAPI_DotNet.Service.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}