using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataLayer.Context;
using Client.DataLayer.Models;
using Client.DataLayer.Repositories;
using Client.DataLayer.Servises;

namespace Client.App
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext db = new MyContext();
            IPersonRepository personRepository = new PersonRepository(db);
            personRepository.InsertPerson(new Person()
            {
                Name = "Mohammad",
                Family = "Alizadeh",
                Mobile = "091000000"
            });
            personRepository.Save();


            db.Dispose();
        }
    }
}
