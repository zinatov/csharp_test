using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class ContactData
    {
        private string name;
        private string lastname;
        private string middlename = "";
        private string nickname = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string fax = "";
        private string email1 = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";
        private string address2 = "";
        private string phone2 = "";
        private string notes = "";
        private string bday = "";
        private string aday = "";
        private string bmonth = "";
        private string amonth = "";
        private string ayear = "";
        private string byear = "";
        private string path = "";

        public ContactData(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }

        public string Work
        {
            get
            {
                return work;
            }
            set
            {
                work = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }

        public string Email1
        {
            get
            {
                return email1;
            }
            set
            {
                email1 = value;
            }
        }

        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }
        }

        public string Email3
        {
            get
            {
                return email3;
            }
            set
            {
                email3 = value;
            }
        }

        public string HomePage
        {
            get
            {
                return homepage;
            }
            set
            {
                homepage = value;
            }
        }

        public string Address2
        {
            get
            {
                return address2;
            }
            set
            {
                address2 = value;
            }
        }

        public string Phone2
        {
            get
            {
                return phone2;
            }
            set
            {
                phone2 = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

        public string ADay
        {
            get
            {
                return aday;
            }
            set
            {
                aday = value;
            }
        }

        public string BDay
        {
            get
            {
                return bday;
            }
            set
            {
                bday = value;
            }
        }

        public string AMonth
        {
            get
            {
                return amonth;
            }
            set
            {
                amonth = value;
            }
        }

        public string BMonth
        {
            get
            {
                return bmonth;
            }
            set
            {
                bmonth = value;
            }
        }

        public string BYear
        {
            get
            {
                return byear;
            }
            set
            {
                byear = value;
            }
        }

        public string AYear
        {
            get
            {
                return ayear;
            }
            set
            {
                ayear = value;
            }
        }

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }
    }
}