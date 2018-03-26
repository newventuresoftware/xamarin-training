using System.Collections.Generic;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace XTraining.Models
{
    public class Customer
    {
        [DisplayOptions(Header = "Address")]
        public string Address { get; set; }

        [DisplayOptions(Header = "City")]
        public string City { get; set; }

        [DisplayOptions(Header = "Company name")]
        public string CompanyName { get; set; }

        [DisplayOptions(Header = "Contact name")]
        public string ContactName { get; set; }

        [DisplayOptions(Header = "Contact title")]
        public string ContactTitle { get; set; }

        [DisplayOptions(Header = "Country")]
        public string Country { get; set; }

        [DisplayOptions(Header = "Customer ID")]
        public string ID { get; set; }

        [DisplayOptions(Header = "Fax")]
        public string Fax { get; set; }

        [DisplayOptions(Header = "Phone")]
        public string Phone { get; set; }

        [DisplayOptions(Header = "PO Code")]
        public string PostalCode { get; set; }

        [DisplayOptions(Header = "Region")]
        public string Region { get; set; }

        public Customer Clone()
        {
            return new Customer()
            {
                Address = this.Address,
                City = this.City,
                CompanyName = this.CompanyName,
                ContactName = this.ContactName,
                ContactTitle = this.ContactTitle,
                Country = this.Country,
                ID = this.ID,
                Fax = this.Fax,
                Phone = this.Phone,
                PostalCode = this.PostalCode,
                Region = this.Region,
            };
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   Address == customer.Address &&
                   City == customer.City &&
                   CompanyName == customer.CompanyName &&
                   ContactName == customer.ContactName &&
                   ContactTitle == customer.ContactTitle &&
                   Country == customer.Country &&
                   ID == customer.ID &&
                   Fax == customer.Fax &&
                   Phone == customer.Phone &&
                   PostalCode == customer.PostalCode &&
                   Region == customer.Region;
        }

        public override int GetHashCode()
        {
            var hashCode = -526004057;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CompanyName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContactName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContactTitle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fax);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PostalCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Region);
            return hashCode;
        }
    }
}
