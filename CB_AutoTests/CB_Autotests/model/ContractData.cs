using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CB_AutoTests
{
    public class ContractData : IEquatable<ContractData>, IComparable<ContractData>
    {
        public ContractData()
        {
        }

        private string contractNumberAndDate;

        public string CleanUp(string text)
        {
            if (text == null || text == "")
            {
                return "";
            }
            return Regex.Replace(text, "[ -()]", "");
        }

        public int CompareTo(ContractData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            if (ContractNumber.CompareTo(other.ContractNumber) == 0)
            {
                return ContractPrice.CompareTo(other.ContractPrice);
            }
            return ContractNumber.CompareTo(other.ContractNumber);
        }

        public bool Equals(ContractData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return ContractPrice == other.ContractPrice && ContractNumber == other.ContractNumber;
        }

        public string ContractNumberAndDate
        {
            get
            {
                if (contractNumberAndDate != null)
                {
                    return contractNumberAndDate;
                }
                else
                {
                    return "№ " + (CleanUp(ContractNumber)) + " от " + (CleanUp(ContractDateDay)) + ".09.2019";
                }
            }
        }

        public string ContractNumber { get; set; }

        public string ContractPrice { get; set; }

        public string ContractNDSPrice { get; set; }

        public string ContractPaymentShedulePrice { get; set; }

        public string ContractDocumentType { get; set; }

        public string ContractDocumentNumberType { get; set; }

        public string ContractDateDay { get; set; }

        public string ResponsiblePersonName { get; set; }

        public string ContractSubject { get; set; }

        public string Signatory { get; set; }
    }
}
