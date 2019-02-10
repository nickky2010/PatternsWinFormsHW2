using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2_Repository.DBRepositories;
using Task2_Repository.EF;
using Task2_Repository.Interfaces;
using Task2_Repository.MemoryRepositories;
using Task2_Repository.Models;
using Task2_Repository.TextFileCSVRepositories;
using Task2_Repository.XmlRepositories;

namespace Task2_Repository
{
    public partial class Form1 : Form
    {
        IRepository<Dog> dbDog;
        IRepository<Cat> dbCat;
        AnimalContext animalContext;
        DbDogRepository dbDogRepository;
        DbCatRepository dbCatRepository;
        TextCSVDogRepository textCSVDogRepository;
        TextCSVCatRepository textCSVCatRepository;
        XmlDogRepository xmlDogRepository;
        XmlCatRepository xmlCatRepository;
        MemDogRepository memDogRepository;
        MemCatRepository memCatRepository;
        List<Dog> dogs;
        List<Cat> cats;
        BindingSource sourceDog;
        BindingSource sourceCat;
        int id;
        string name;
        int age;
        double weight;
        bool initRepoDB = false;
        bool initRepoMemory = false;

        public Form1()
        {
            InitializeComponent();
            comboBoxRepository.Items.Add("Database");
            comboBoxRepository.Items.Add("Text file");
            comboBoxRepository.Items.Add("Xml-documents");
            comboBoxRepository.Items.Add("Memory");
            comboBoxRepository.SelectedIndex = 0;
            comboBoxChooseRepository.Items.Add("Dogs");
            comboBoxChooseRepository.Items.Add("Cats");
            comboBoxChooseRepository.SelectedIndex = 0;
            comboBoxOperation.Items.Add("Create");
            comboBoxOperation.Items.Add("Delete");
            comboBoxOperation.Items.Add("Update");
            comboBoxOperation.SelectedIndex = 0;
            // data
            dogs = new List<Dog> {
                new Dog { Id = 1, Name = "Grommit", Age = 7 },
                new Dog { Id = 2, Name = "Dag", Age = 3 },
                new Dog { Id = 3, Name = "Jonny", Age = 13 },
                new Dog { Id = 4, Name = "Dino", Age = 6 },
                new Dog { Id = 5, Name = "Druppy", Age = 9 }
            };
            cats = new List<Cat> {
                new Cat { Id = 1, Name = "Cattovische", Weight = 27.9 },
                new Cat { Id = 2, Name = "Kiss", Weight = 3.7 },
                new Cat { Id = 3, Name = "Missy", Weight = 5.6 },
                new Cat { Id = 4, Name = "Kiska", Weight = 8.5 },
                new Cat { Id = 5, Name = "Bryss", Weight = 7.4 }
            };
            sourceDog = new BindingSource();
            sourceCat = new BindingSource();
            dataGridViewDogs.DataSource = sourceDog;
            dataGridViewCats.DataSource = sourceCat;

            string dir = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            // database
            string connectionString = @"Data Source=(LocalDB)\mssqllocaldb;AttachDbFilename='" + dir + @"\App_Data\AnimalStore.mdf';Integrated Security=True";
            animalContext = new AnimalContext(connectionString);
            dbDogRepository = new DbDogRepository(animalContext);
            dbCatRepository = new DbCatRepository(animalContext);
            // TextCSVRepository
            textCSVDogRepository = new TextCSVDogRepository(dir + @"\App_Data\Dogs.csv");
            textCSVCatRepository = new TextCSVCatRepository(dir + @"\App_Data\Cats.csv");
            // XmlRepository
            xmlDogRepository = new XmlDogRepository(dir + @"\App_Data\Dogs.xml");
            xmlCatRepository = new XmlCatRepository(dir + @"\App_Data\Cats.xml");
            // Memory
            memDogRepository = new MemDogRepository();
            memCatRepository = new MemCatRepository();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            switch (comboBoxRepository.SelectedIndex)
            {
                case 0:
                    {
                        if (!initRepoDB)
                        {
                            dogs[0].Name = "Grommit(database)";
                            cats[0].Name = "Cattovische(database)";
                            try
                            {
                                dogs.ForEach(d => dbDogRepository.Create(d));
                                cats.ForEach(c => dbCatRepository.Create(c));
                                initRepoDB = true;
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        dbDog = dbDogRepository;
                        dbCat = dbCatRepository;
                        break;
                    }
                case 1:
                    {
                        dbDog = textCSVDogRepository;
                        dbCat = textCSVCatRepository;
                        break;
                    }
                case 2:
                    {
                        dbDog = xmlDogRepository;
                        dbCat = xmlCatRepository;
                        break;
                    }
                case 3:
                    {
                        if (!initRepoMemory)
                        {
                            dogs[0].Name = "Grommit(memory)";
                            cats[0].Name = "Cattovische(memory)";
                            dogs.ForEach(d => memDogRepository.Create(d));
                            cats.ForEach(c => memCatRepository.Create(c));
                            initRepoMemory = true;
                        }
                        dbDog = memDogRepository;
                        dbCat = memCatRepository;
                        break;
                    }
            }
            sourceDog.DataSource = dbDog.GetAll().ToList();
            sourceCat.DataSource = dbCat.GetAll().ToList();
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            name = "";
            try
            {
                name = textBox2.Text;
                if (name == "")
                    throw new Exception("Please enter name!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox2.Text = "";
                textBox2.Focus();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxChooseRepository.SelectedIndex == 0)
                {
                    age = Convert.ToInt32(textBox3.Text);
                    if (age < 0)
                        throw new Exception("Weight must be equal or greater than zero!");
                }
                else
                {
                    weight = Convert.ToDouble(textBox3.Text);
                    if (weight <= 0)
                        throw new Exception("Weight must be greater than zero!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox3.Text = "";
                textBox3.Focus();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxChooseRepository.SelectedIndex)
                {
                    case 0:
                        {
                            switch (comboBoxOperation.SelectedIndex)
                            {
                                case 0:
                                    {
                                        dbDog.Create(new Dog { Id = id, Name = name, Age = age });
                                        break;
                                    }
                                case 1:
                                    {
                                        dbDog.Delete(id);
                                        break;
                                    }
                                case 2:
                                    {
                                        dbDog.Update(new Dog { Id = id, Name = name, Age = age });
                                        break;
                                    }
                            }
                            sourceDog.DataSource = dbDog.GetAll().ToList();
                            break;
                        }
                    case 1:
                        {
                            switch (comboBoxOperation.SelectedIndex)
                            {
                                case 0:
                                    {
                                        dbCat.Create(new Cat { Id = id, Name = name, Weight = weight });
                                        break;
                                    }
                                case 1:
                                    {
                                        dbCat.Delete(id);
                                        break;
                                    }
                                case 2:
                                    {
                                        dbCat.Update(new Cat { Id = id, Name = name, Weight = weight });
                                        break;
                                    }
                            }
                            sourceCat.DataSource = dbCat.GetAll().ToList();
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxChooseRepository_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseRepository.SelectedIndex == 0)
                label7.Text = "Age";
            else
                label7.Text = "Weight";
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperation.SelectedIndex == 1)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }
    }
}
