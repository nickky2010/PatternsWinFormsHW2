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
    class TextCSVCatRepository : IRepository<Cat>
    {
        List<Cat> cats;
        string pathFile;
        public TextCSVCatRepository(string pathFile)
        {
            this.pathFile = pathFile;
            cats = new List<Cat>();
        }
        public void Create(Cat item)
        {
            if (!cats.Any(d => d.Id == item.Id))
            {
                cats.Add(item);
                Write();
            }
            else
                throw new Exception("This cat already exists!");
        }

        public void Delete(int id)
        {
            cats.Remove(cats.Find(a => a.Id == id));
            Write();
        }

        public Cat Get(int id)
        {
            Read();
            return cats.Find(a => a.Id == id);
        }

        public IEnumerable<Cat> GetAll()
        {
            Read();
            return cats;
        }

        public void Update(Cat item)
        {
            int i = -1;
            i = cats.FindIndex(a => a.Id == item.Id);
            if (i > -1)
            {
                cats[i].Name = item.Name;
                cats[i].Weight = item.Weight;
                Write();
            }
            else
                throw new Exception("This id does not exist!");
        }
        private void Read()
        {
            using (StreamReader reader = new StreamReader(pathFile))
            {
                cats.Clear();
                while (!reader.EndOfStream)
                {
                    try
                    {
                        string[] temp = reader.ReadLine().Split(';');
                        cats.Add(new Cat() { Id = Convert.ToInt32(temp[0]), Name = temp[1], Weight = Convert.ToDouble(temp[2]) });
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
                foreach (Cat item in cats)
                {
                    builder.Append(item.Id).Append(";").Append(item.Name).Append(";").Append(item.Weight);
                    writer.WriteLine(builder.ToString());
                    builder.Clear();
                }
            }
        }
    }
}
