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
    class DbCatRepository : IRepository<Cat>
    {
        AnimalContext context;
        private DbSet<Cat> dbset;

        public DbCatRepository(AnimalContext context)
        {
            this.context = context;
            dbset = context.Set<Cat>();
        }
        public void Create(Cat item)
        {
            Cat cat = dbset.Find(item.Id);
            if (cat == null)
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
            Cat cat = dbset.Find(id);
            if (cat != null)
            {
                dbset.Remove(cat);
                context.SaveChanges();
            }
            else
                throw new Exception("This id does not exist!");
        }

        public Cat Get(int id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<Cat> GetAll()
        {
            return context.Cats;
        }

        public void Update(Cat item)
        {
            Cat cat = dbset.Find(item.Id);
            if (cat != null)
            {
                cat.Name = item.Name;
                cat.Weight = item.Weight;
                dbset.Attach(cat);
                context.Entry(cat).State = EntityState.Modified;
                context.SaveChanges();
            }
            else
                throw new Exception("This id does not exist!");
        }
    }
}
