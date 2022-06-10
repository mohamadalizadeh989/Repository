using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataLayer.Models;

namespace Client.DataLayer.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetAllPerson();
        Person GetPersonById(int personId);
        void InsertPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
        void DeletePerson(int personId);
        void Save();

    }
}
