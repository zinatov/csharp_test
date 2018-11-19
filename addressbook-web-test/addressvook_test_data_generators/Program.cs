using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WebAddressbookTests;

namespace addressvook_test_data_generators
{
    class Program
    {
        static void Main(string[] args)
        {
            String dataType = args[0];
            int count = Convert.ToInt32(args[1]);
            StreamWriter writer = new StreamWriter(args[2]);
            String format = args[3];
            List<GroupData> groups = new List<GroupData>();
            List<ContactData> contacts = new List<ContactData>();

            for (int i = 0; i < count; i++)
            {
                groups.Add(new GroupData(TestBase.GenerateRandonString(10))
                {
                    Header = TestBase.GenerateRandonString(10),
                    Footer = TestBase.GenerateRandonString(10)
                });
            }

            for (int i = 0; i < count; i++)
            {
                contacts.Add(new ContactData(TestBase.GenerateRandonString(10), TestBase.GenerateRandonString(10))
                {
                    MiddleName = TestBase.GenerateRandonString(10),
                    Nickname = TestBase.GenerateRandonString(10),
                    Title = TestBase.GenerateRandonString(20),
                    Company = TestBase.GenerateRandonString(20),
                    Address = TestBase.GenerateRandonString(20),
                    Home = TestBase.GenerateRandonString(10),
                    Mobile = TestBase.GenerateRandonString(10),
                    Work = TestBase.GenerateRandonString(10),
                    Fax = TestBase.GenerateRandonString(10),
                    Email1 = TestBase.GenerateRandonString(10),
                    Email2 = TestBase.GenerateRandonString(10),
                    Email3 = TestBase.GenerateRandonString(10),
                    HomePage = TestBase.GenerateRandonString(20),
                    Address2 = TestBase.GenerateRandonString(20),
                    Phone2 = TestBase.GenerateRandonString(10),
                    Notes = TestBase.GenerateRandonString(30)
                });
            }

            if (dataType == "contact")
            {
                if (format == "xml")
                {
                    writeContactsToXmlFile(contacts, writer);
                }
                else if (format == "json")
                {
                    writeContactsToJsonFile(contacts, writer);
                }
                else
                {
                    System.Console.Out.Write("Neverny Format " + format);
                }
            }
            else if (dataType == "group")
            {
                if (format == "csv")
                {
                    writeGroupsToCsvFile(groups, writer);
                }
                else if (format == "xml")
                {
                    writeGroupsToXmlFile(groups, writer);
                }
                else if (format == "json")
                {
                    writeGroupsToJsonFile(groups, writer);
                }
                else
                {
                    System.Console.Out.Write("Neverny Format " + format);
                }
            }
            else
            {
                System.Console.Out.Write("Neverny tip " + dataType);
            }
            writer.Close();
        }

        //contacts
        static void writeContactsToXmlFile(List<ContactData> contacts, StreamWriter writer)
        {
            new XmlSerializer(typeof(List<ContactData>)).Serialize(writer, contacts);
        }

        static void writeContactsToJsonFile(List<ContactData> contacts, StreamWriter writer)
        {
            writer.Write(JsonConvert.SerializeObject(contacts, Newtonsoft.Json.Formatting.Indented));
        }

        //groups
        static void writeGroupsToCsvFile(List<GroupData> groups, StreamWriter writer)
        {
            foreach (GroupData group in groups)
            {
                writer.WriteLine(String.Format("${0},${1},${2}",
                    group.Name, group.Header, group.Footer));
            }
        }

        static void writeGroupsToXmlFile(List<GroupData> groups, StreamWriter writer)
        {
            new XmlSerializer(typeof(List<GroupData>)).Serialize(writer, groups);
        }

        static void writeGroupsToJsonFile(List<GroupData> groups, StreamWriter writer)
        {
            writer.Write(JsonConvert.SerializeObject(groups, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
