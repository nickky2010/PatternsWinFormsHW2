using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_Repository.Interfaces;
using Task2_Repository.Models;

namespace Task2_Repository.MemoryRepositories
{
    class MemCatRepository : IRepository<Cat>
    {
        static List<Cat> Cats;
        static MemCatRepository()
        {
            Cats = new List<Cat>();
        }
        public void Create(Cat item)
        {
            if (!Cats.Any(d => d.Id == item.Id))
                Cats.Add(item);
            else
                throw new Exception("This cat already exists!");
        }

        public void Delete(int id)
        {
            Cat Cat = Cats.First(d => d.Id == id);
            Cats.Remove(Cat);
        }


        public Cat Get(int id)
        {
            return Cats.First(d => d.Id == id);
        }

        public IEnumerable<Cat> GetAll()
        {
            return Cats;
        }

        public void Update(Cat item)
        {
            int i = -1;
            i = Cats.FindIndex(a => a.Id == item.Id);
            if (i > -1)
            {
                Cats[i].Name = item.Name;
                Cats[i].Weight = item.Weight;
            }
            else
                throw new Exception("This id does not exist!");
        }
    }
}
