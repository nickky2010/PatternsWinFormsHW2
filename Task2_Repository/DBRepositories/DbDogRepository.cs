using Task2_Repository.EF;
using Task2_Repository.Interfaces;
using Task2_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Task2_Repository.DBRepositories
{
    class DbDogRepository : IRepository<Dog>
    {
        AnimalContext context;
        private DbSet<Dog> dbset;

        public DbDogRepository(AnimalContext context)
        {
            this.context = context;
            dbset = context.Set<Dog>();
        }
        public void Create(Dog item)
        {
            Dog dog = dbset.Find(item.Id);
            if (dog == null)
            {
                dbset.Add(item);
                context.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
                context.Entry(item).State = EntityState.Added;
                context.SaveChanges();
            }
            else
                throw new Exception("This id does not exist!");
        }

        public void Delete(int id)
        {
            Dog dog = dbset.Find(id);
            if (dog != null)
            {
                dbset.Remove(dog);
                context.SaveChanges();
            }
        }

        public Dog Get(int id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<Dog> GetAll()
        {
            return context.Dogs;
        }

        public void Update(Dog item)
        {
            Dog dog = dbset.Find(item.Id);
            if (dog != null)
            {
                dog.Name = item.Name;
                dog.Age = item.Age;
                dbset.Attach(dog);
                context.Entry(dog).State = EntityState.Modified;
                context.SaveChanges();
            }
            else
                throw new Exception("This id does not exist!");
        }
    }
}
