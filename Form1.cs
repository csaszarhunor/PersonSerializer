using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializer
{
    public partial class FormPersons : Form
    {
        public FormPersons()
        {
            InitializeComponent();
        }

        private string currentSerialNum;
        private DirectoryInfo storedPersons = new DirectoryInfo("Persons");

        private void FormPersons_Load(object sender, EventArgs e)
        {
            if (!storedPersons.Exists) storedPersons.Create();
            if (storedPersons.GetFiles().Length > 0)
            {
                currentSerialNum = "01";
                Person currentPerson = Deserialize();
                LoadPerson(currentPerson);
            }
        }
        
        private void saveBttn_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = nameTxtBox.Text;
            person.Address = addressTxtBox.Text;
            person.Phone = phoneTxtBox.Text;
            person.DateOfRecording = DateTime.Now;
            person.serialNumber = DefineSerialNumber();

            currentSerialNum = person.serialNumber;
            Serialize(person);
        }

        private void previousBttn_Click(object sender, EventArgs e)
        {
            try
            {
                currentSerialNum = DecreaseSerialByOne(currentSerialNum);
                Person currentPerson = Deserialize();
                LoadPerson(currentPerson);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nextBttn_Click(object sender, EventArgs e)
        {
            try
            {
                currentSerialNum = IncreaseSerialByOne(currentSerialNum);
                Person currentPerson = Deserialize();
                LoadPerson(currentPerson);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                currentSerialNum = DecreaseSerialByOne(currentSerialNum);
            }
        }

        private void Serialize(Person person)
        {
            string path = String.Concat(@"Persons\person.", person.serialNumber, ".dat");
            FileStream fileStream = new FileStream(path, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, person);
            fileStream.Close();
        }

        private Person Deserialize()
        {
            string path = String.Concat(@"Persons\person.", currentSerialNum, ".dat");
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("There isn't any more persons stored.");
            }
            FileStream fileStream = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Person person = (Person)formatter.Deserialize(fileStream);
            fileStream.Close();
            return person;
        }
        
        private void LoadPerson(Person person)
        {
            nameTxtBox.Text = person.Name;
            addressTxtBox.Text = person.Address;
            phoneTxtBox.Text = person.Phone;
        }

        private string DefineSerialNumber()
        {
            FileInfo[] persons = storedPersons.GetFiles();
            if (persons.Length == 0)
            {
                return "01";
            }
            else
            {
                string fileName = Path.GetFileNameWithoutExtension(persons[persons.Length - 1].Name);
                string previousSerial = fileName.Substring(fileName.Length - 2);
                return IncreaseSerialByOne(previousSerial);
            }
        }

        private string IncreaseSerialByOne(string serial)
        {
            int tempNum = Int32.Parse(serial) + 1;
            if (tempNum > 99) throw new IndexOutOfRangeException("Serial number cannot go above 99.");
            if (tempNum < 10) return string.Concat("0", tempNum);
            else return tempNum.ToString();
        }

        private string DecreaseSerialByOne(string serial)
        {
            int tempNum = Int32.Parse(serial) - 1;
            if (tempNum <= 0) throw new IndexOutOfRangeException("Serial number cannot go under 01.");
            if (tempNum < 10) return string.Concat("0", tempNum);
            else return tempNum.ToString();
        }
    }
}
