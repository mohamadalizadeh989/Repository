using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DataLayer.Models;

namespace Client.DataLayer.Context
{
    public class MyContext :DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
