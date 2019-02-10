using Task2_Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Repository.EF
{
    class AnimalContext:DbContext
    {
        public string ConnectionString { get; set; }
        public AnimalContext() : base("name=AnimalStore")
        {

        }
        public AnimalContext(string cs) : base(cs)
        {
            ConnectionString = cs;
        }

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Cat> Cats { get; set; }
    }
}
