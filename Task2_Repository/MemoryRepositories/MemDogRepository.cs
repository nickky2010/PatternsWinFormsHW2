using Task2_Repository.Interfaces;
using Task2_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Repository.MemoryRepositories
{
    class MemDogRepository : IRepository<Dog>
    {
        static List<Dog> dogs;
        static MemDogRepository()
        {
            dogs = new List<Dog>();
        }
        public void Create(Dog item)
        {
            if (!dogs.Any(d => d.Id == item.Id))
                dogs.Add(item);
            else
                throw new Exception("This dog already exists!");
        }

        public void Delete(int id)
        {
            Dog dog = dogs.First(d => d.Id == id);
            dogs.Remove(dog);
        }
    

        public Dog Get(int id)
        {
            return dogs.First(d => d.Id == id); 
        }

        public IEnumerable<Dog> GetAll()
        {
            return dogs;
        }

        public void Update(Dog item)
        {
            int i = -1;
            i = dogs.FindIndex(a => a.Id == item.Id);
            if (i > -1)
            {
                dogs[i].Name = item.Name;
                dogs[i].Age = item.Age;
            }
            else
                throw new Exception("This id does not exist!");
        }
    }
}
