using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Firebrand.Demos.Demo16_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[] 
            {
                new Person(150000){Name = "bob", Age = 121},
                new Person(10000){Name = "Ash", Age = 25},
                new Person(50000){Name = "Sam", Age = 22}
            };
            var dir = Directory.GetCurrentDirectory();
            var fileName = dir + "\\test.txt";

            //var formatter = new DataContractJsonSerializer(typeof(Person[]));
            //var formatter = new SoapFormatter();
            var formatter = new XmlSerializer(typeof(Person[]));

            //serializer
            using (FileStream stream = File.Create(fileName))
            {
                formatter.Serialize(stream, people);
                //formatter.WriteObject(stream, people); //for json
            }
            Console.ReadKey();
        }
    }

    [Serializable]
    public class Person : ISerializable
    {
        public string Name;
        private decimal Salary; //will not be serialized because its not public

        [NonSerialized] // read by runtime seriliazers
        [XmlIgnore] // read by XML serilaizer
        [IgnoreDataMember] //wcf Data ontract
        public int Level;

        public int Age { get; set; }

        public Person()
        {

        }

        public decimal GetSalary { get { return Salary; } }
        public Person(decimal salary)
        {
            Salary = salary;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //gets executed when we serialize an object
            info.AddValue("name", Name);
            info.AddValue("age", Age);
            info.AddValue("salary", Salary);
            info.AddValue("level", Level);
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            //gets execute when we deserialize
            Name = info.GetString("name");
            Age = info.GetInt32("age");
            Salary = info.GetDecimal("salary");
            Level = info.GetInt32("level");
        }
    }
}
