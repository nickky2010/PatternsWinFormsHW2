using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_Repository.Interfaces;
using Task2_Repository.Models;

namespace Task2_Repository.TextFileCSVRepositories
{
    class TextCSVDogRepository : IRepository<Dog>
    {
        List<Dog> dogs;
        string pathFile;
        public TextCSVDogRepository(string pathFile)
        {
            this.pathFile = pathFile;
            dogs = new List<Dog>();
        }
        public void Create(Dog item)
        {
            if (!dogs.Any(d => d.Id == item.Id))
            {
                dogs.Add(item);
                Write();
            }
            else
                throw new Exception("This dog already exists!");
        }

        public void Delete(int id)
        {
            dogs.Remove(dogs.Find(a => a.Id == id));
            Write();
        }

        public Dog Get(int id)
        {
            Read();
            return dogs.Find(a => a.Id == id);
        }

        public IEnumerable<Dog> GetAll()
        {
            Read();
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
                Write();
            }
            else
                throw new Exception("This id does not exist!");
        }
        private void Read()
        {
            using (StreamReader reader = new StreamReader(pathFile))
            {
                dogs.Clear();
                while (!reader.EndOfStream)
                {
                    try
                    {
                        string[] temp = reader.ReadLine().Split(';');
                        dogs.Add(new Dog() { Id = Convert.ToInt32(temp[0]), Name = temp[1], Age = Convert.ToInt32(temp[2]) });
                    }
                    catch
                    {
                        throw new Exception("Could not read csv file in directory " + pathFile);
                    }
                }
            }
        }
        private void Write()
        {
            StringBuilder builder;
            using (StreamWriter writer = new StreamWriter(pathFile))
            {
                builder = new StringBuilder();
                foreach (Dog item in dogs)
                {
                    builder.Append(item.Id).Append(";").Append(item.Name).Append(";").Append(item.Age);
                    writer.WriteLine(builder.ToString());
                    builder.Clear();
                }
            }
        }
    }
}
