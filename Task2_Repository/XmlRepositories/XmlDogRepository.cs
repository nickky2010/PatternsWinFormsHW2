using Task2_Repository.Interfaces;
using Task2_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Task2_Repository.XmlRepositories
{
    class XmlDogRepository : IRepository<Dog>
    {
        XmlDocument document;
        string fileName;
        public XmlDogRepository(string fileName)
        {
            document = new XmlDocument();
            this.fileName = fileName;
        }
        public void Create(Dog item)
        {
            document.Load(fileName);
            XmlElement xRoot = document.DocumentElement;
            // создаем новый элемент dog
            XmlElement dogElem = document.CreateElement("dog");
            // создаем атрибут id
            XmlAttribute idAttr = document.CreateAttribute("id");
            // создаем элементы name и age
            XmlElement nameElem = document.CreateElement("name");
            XmlElement ageElem = document.CreateElement("age");
            // создаем текстовые значения для элементов и атрибута
            XmlText id = document.CreateTextNode(item.Id.ToString());
            XmlText nameText = document.CreateTextNode(item.Name);
            XmlText ageText = document.CreateTextNode(item.Age.ToString());
            //добавляем узлы
            idAttr.AppendChild(id);
            nameElem.AppendChild(nameText);
            ageElem.AppendChild(ageText);
            dogElem.Attributes.Append(idAttr);
            dogElem.AppendChild(nameElem);
            dogElem.AppendChild(ageElem);
            xRoot.AppendChild(dogElem);
            document.Save(fileName);
        }

        public void Delete(int id)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement root = xdoc.Element("dogs");
            var r = root.Elements("dog").FirstOrDefault(d => d.Attribute("id").Value == id.ToString());
            if (r != null)
            {
                r.Remove();
                xdoc.Save(fileName);
            }
            else
                throw new Exception("This id does not exist!");
        }

        public Dog Get(int id)
        {
            XDocument doc = XDocument.Load(fileName);
           
            var result = (from d in doc.Descendants(XName.Get("dog"))
                         where Convert.ToInt32(d.Attribute(XName.Get("id")).Value) ==id
                         select d).FirstOrDefault();
            Dog dog = new Dog();
            dog.Id = Convert.ToInt32(result.Attribute(XName.Get("id")).Value);
            dog.Name = result.Element(XName.Get("name")).Value;
            dog.Age = Convert.ToInt32(result.Element(XName.Get("age")).Value);
            return dog;
        }

        public IEnumerable<Dog> GetAll()
        {
            document.Load(fileName);
            
            List<Dog> dogs = new List<Dog>();
            XmlNodeList dogNodes = document.DocumentElement.GetElementsByTagName("dog");
            foreach (XmlNode node in dogNodes)
            {
                Dog dog = new Dog();
                dog.Id= Convert.ToInt32(node.Attributes["id"].Value);
                dog.Name = node["name"].InnerText;
                dog.Age= Convert.ToInt32(node["age"].InnerText);
                dogs.Add(dog);
            }
            return dogs;
        }

        public void Update(Dog item)
        {
            XDocument doc = XDocument.Load(fileName);
            XElement xElemAgent = doc.Descendants("dog")
            .Where(arg => arg.Attribute("id").Value == item.Id.ToString()).Single();
            if (xElemAgent != null)
            {
                xElemAgent.SetElementValue("name", item.Name);
                xElemAgent.SetElementValue("age", item.Age);
                doc.Save(fileName);
            }
            else
                throw new Exception("This id does not exist!");
        }
    }
}
