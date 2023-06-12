using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Xml.Serialization;

namespace HomeWork_12
{
    internal class Program
    {
        public class Person
        {
            public string? Name { get; set; }
            public string? LastName { get; set; }
            public string? Number { get; set; }

            public Person(string name, string lastname, string number)
            {
                this.Name = name;
                this.LastName = lastname;
                this.Number = number;
            }

            public override string ToString()
            {
                return $"Person Name = {Name}, Person SurName = {LastName}, Person Number = {Number}";
            }
        }
        static void Main(string[] args)
        {
            // JSON
            Person person1 = new Person("Anton", "Skochylias", "+380974468233");
            Stream file = new FileStream("person1.json", FileMode.Create);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            ser.WriteObject(file, person1);

            // XML
            Person person2 = new Person("Toni", "Vercetti", "+380965532722");
            XmlSerializer xmlser = new XmlSerializer(typeof(Person));
            Stream serialStream = new FileStream("person2.xml", FileMode.Create);
            xmlser.Serialize(serialStream, person2);

            // Binary
            Person person3 = new Person("Antoni", "Caravadjo", "+380953244732");
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("person3.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, person3);
            stream.Close();
        }
    }
}