using System.Collections.Generic;
using RestAPI_DotNet.Model;

namespace RestAPI_DotNet.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}