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
    class XmlCatRepository : IRepository<Cat>
    {
        XmlDocument document;
        string fileName;
        public XmlCatRepository(string fileName)
        {
            document = new XmlDocument();
            this.fileName = fileName;
        }
        public void Create(Cat item)
        {
            document.Load(fileName);
            XmlElement xRoot = document.DocumentElement;
            // создаем новый элемент cat
            XmlElement catElem = document.CreateElement("cat");
            // создаем атрибут id
            XmlAttribute idAttr = document.CreateAttribute("id");
            // создаем элементы name и weight
            XmlElement nameElem = document.CreateElement("name");
            XmlElement weightElem = document.CreateElement("weight");
            // создаем текстовые значения для элементов и атрибута
            XmlText id = document.CreateTextNode(item.Id.ToString());
            XmlText nameText = document.CreateTextNode(item.Name);
            XmlText weightText = document.CreateTextNode(item.Weight.ToString());
            //добавляем узлы
            idAttr.AppendChild(id);
            nameElem.AppendChild(nameText);
            weightElem.AppendChild(weightText);
            catElem.Attributes.Append(idAttr);
            catElem.AppendChild(nameElem);
            catElem.AppendChild(weightElem);
            xRoot.AppendChild(catElem);
            document.Save(fileName);
        }

        public void Delete(int id)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement root = xdoc.Element("cats");
            var r = root.Elements("cat").FirstOrDefault(d => d.Attribute("id").Value == id.ToString());
            if (r != null)
            {
                r.Remove();
                xdoc.Save(fileName);
            }
            else
                throw new Exception("This id does not exist!");
        }

        public Cat Get(int id)
        {
            XDocument doc = XDocument.Load(fileName);

            var result = (from d in doc.Descendants(XName.Get("cat"))
                          where Convert.ToInt32(d.Attribute(XName.Get("id")).Value) == id
                          select d).FirstOrDefault();
            Cat cat = new Cat();
            cat.Id = Convert.ToInt32(result.Attribute(XName.Get("id")).Value);
            cat.Name = result.Element(XName.Get("name")).Value;
            cat.Weight = Convert.ToDouble(result.Element(XName.Get("weight")).Value);
            return cat;
        }

        public IEnumerable<Cat> GetAll()
        {
            document.Load(fileName);

            List<Cat> cats = new List<Cat>();
            XmlNodeList catNodes = document.DocumentElement.GetElementsByTagName("cat");
            foreach (XmlNode node in catNodes)
            {
                Cat cat = new Cat();
                cat.Id = Convert.ToInt32(node.Attributes["id"].Value);
                cat.Name = node["name"].InnerText;
                cat.Weight = Convert.ToDouble(node["weight"].InnerText);
                cats.Add(cat);
            }
            return cats;
        }

        public void Update(Cat item)
        {
            XDocument doc = XDocument.Load(fileName);
            XElement xElemAgent = doc.Descendants("cat")
            .Where(arg => arg.Attribute("id").Value == item.Id.ToString()).Single();
            if (xElemAgent != null)
            {
                xElemAgent.SetElementValue("name", item.Name);
                xElemAgent.SetElementValue("weight", item.Weight);
                doc.Save(fileName);
            }
            else
                throw new Exception("This id does not exist!");
        }
    }
}
