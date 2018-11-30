using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace mantis_tests
{
    public class ProjectData : IEquatable<ProjectData>, IComparable<ProjectData>
    {
        public ProjectData()
        {}

        public string Name { get; set; }

        public string Description { get; set; }

        public int CompareTo(ProjectData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            if (Name.CompareTo(other.Name) == 0)
            {
                return Description.CompareTo(other.Description);
            }
            return Name.CompareTo(other.Name);
        }

        public bool Equals(ProjectData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name && Description == other.Description;
        }

        public override string ToString()
        {
            return "name= " + Name
                + "\ndescription= " + Description;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Description.GetHashCode();
        }
    }
}
