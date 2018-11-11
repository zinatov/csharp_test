﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        public ContactData(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
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
            return " name= " + Name + " lastname " + LastName;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }

        public string Name { get; set; }

        public string LastName { get; set; }
 
        public string MiddleName { get; set; }

        public string Nickname { get; set; }
 
        public string Title { get; set; }

        public string Company { get; set; }   

        public string Address { get; set; }

        public string Home { get; set; }
       
        public string Mobile { get; set; } 

        public string Work { get; set; }

        public string Fax { get; set; }
      
        public string Email1 { get; set; }
     
        public string Email2 { get; set; }

        public string Email3 { get; set; }
     
        public string HomePage { get; set; }
      
        public string Address2 { get; set; }

        public string Phone2 { get; set; }

        public string Notes { get; set; }

        public string ADay { get; set; }

        public string BDay { get; set; }

        public string AMonth { get; set; }

        public string BMonth { get; set; }

        public string BYear { get; set; }

        public string AYear { get; set; }

        public string Path { get; set; }

        public string Id { get; set; }
    }
}