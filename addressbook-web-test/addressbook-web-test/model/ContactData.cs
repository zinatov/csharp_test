using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LinqToDB.Mapping;

namespace WebAddressbookTests
{
    [Table(Name = "addressbook")]
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string allPhones;
        private string allEmails;

        public ContactData(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        public ContactData()
        {
        }

        public bool Equals(ContactData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name && LastName == other.LastName;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + LastName.GetHashCode();
        }

        public override string ToString()
        {
            return "name= " + Name
                + "\nlastname= " + LastName
                + "\nmiddlename= " + MiddleName
                + "\nnickname= " + Nickname
                + "\ntitle= " + Title
                + "\ncompany= " + Company
                + "\naddress= " + Address
                + "\nhome= " + Home
                + "\nmobile= " + Mobile
                + "\nwork= " + Work
                + "\nfax= " + Fax
                + "\nemail1= " + Email1
                + "\nemail2= " + Email2
                + "\nemail3= " + Email3
                + "\nhomepage= " + HomePage
                + "\naddress2= " + Address2
                + "\nphone2= " + Phone2
                + "\nnotes= " + Notes;

        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            if (LastName.CompareTo(other.LastName) == 0)
            {
                return Name.CompareTo(other.Name);
            }
            return LastName.CompareTo(other.LastName);
        }

        public string AllPhones
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(Home) + "\r\n" + CleanUp(Mobile) + "\r\n" + CleanUp(Work) + "\r\n" + CleanUp(Phone2)).Trim();
                }
            }

            set
            {
                allPhones = value;
            }
        }

        public string CleanUp(string text)
        {
            if(text == null || text == "")
            {
                return "";
            }
            return Regex.Replace(text, "[ -()]", "");
        }

        [Column(Name = "firstname")]
        public string Name { get; set; }

        [Column(Name = "lastname")]
        public string LastName { get; set; }

        [Column(Name = "middlename")]
        public string MiddleName { get; set; }

        [Column(Name = "nickname")]
        public string Nickname { get; set; }

        [Column(Name = "title")]
        public string Title { get; set; }

        [Column(Name = "company")]
        public string Company { get; set; }

        [Column(Name = "address")]
        public string Address { get; set; }

        [Column(Name = "home")]
        public string Home { get; set; }

        [Column(Name = "mobile")]
        public string Mobile { get; set; }

        [Column(Name = "work")]
        public string Work { get; set; }

        [Column(Name = "fax")]
        public string Fax { get; set; }

        [Column(Name = "email")]
        public string Email1 { get; set; }

        [Column(Name = "email2")]
        public string Email2 { get; set; }

        [Column(Name = "email3")]
        public string Email3 { get; set; }

        public string AllEmails
        {
            get
            {
                if (allEmails != null)
                {
                    return allEmails;
                }
                else
                {
                    return (CleanUp(Email1) + "\r\n" + CleanUp(Email2) + "\r\n" + CleanUp(Email3)).Trim();
                }
            }

            set
            {
                allEmails = value;
            }
        }

        [Column(Name = "homepage")]
        public string HomePage { get; set; }

        [Column(Name = "address2")]
        public string Address2 { get; set; }

        [Column(Name = "phone2")]
        public string Phone2 { get; set; }

        [Column(Name = "notes")]
        public string Notes { get; set; }

        [Column(Name = "deprecated")]
        public string Deprecated { get; set; }

        public string ADay { get; set; }

        public string BDay { get; set; }

        public string AMonth { get; set; }

        public string BMonth { get; set; }

        public string BYear { get; set; }

        public string AYear { get; set; }

        public string Path { get; set; }

        [Column(Name = "id"), PrimaryKey, Identity]
        public string Id { get; set; }

        public static List<ContactData> GetAll()
        {
            using (AddressBookDB db = new AddressBookDB())
            {
                return (from c in db.Contacts.Where(x => x.Deprecated == "0000-00-00 00:00:00") select c ).ToList();
            }
        }
    }
}
