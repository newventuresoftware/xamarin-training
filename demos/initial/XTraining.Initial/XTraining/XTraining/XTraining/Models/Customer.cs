using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//using Telerik.XamarinForms.Common.DataAnnotations;

namespace XTraining.Models
{
    public class Customer : INotifyPropertyChanged
    {
        private string _address, _city, _companyName, _contactName, _contactTitle,
            _country, _id, _fax, _phone, _postalCode, _region;

        //[DisplayOptions(Header = "Address")]
        public string Address { get => _address; set => SetValue(ref _address, value); }

        //[DisplayOptions(Header = "City")]
        public string City { get => _city; set => SetValue(ref _city, value); }

        //[DisplayOptions(Header = "Company name")]
        //[NonEmptyValidator]
        public string CompanyName { get => _companyName; set => SetValue(ref _companyName, value); }

        //[DisplayOptions(Header = "Contact name")]
        public string ContactName { get => _contactName; set => SetValue(ref _contactName, value); }

        //[DisplayOptions(Header = "Contact title")]
        public string ContactTitle { get => _contactTitle; set => SetValue(ref _contactTitle, value); }

        //[DisplayOptions(Header = "Country")]
        public string Country { get => _country; set => SetValue(ref _country, value); }

        //[DisplayOptions(Header = "Customer ID")]
        //[StringLengthValidator(5, 5)]
        public string ID { get => _id; set => SetValue(ref _id, value); }

        //[DisplayOptions(Header = "Fax")]
        public string Fax { get => _fax; set => SetValue(ref _fax, value); }

        //[DisplayOptions(Header = "Phone")]
        public string Phone { get => _phone; set => SetValue(ref _phone, value); }

        //[DisplayOptions(Header = "PO Code")]
        public string PostalCode { get => _postalCode; set => SetValue(ref _postalCode, value); }

        //[DisplayOptions(Header = "Region")]
        public string Region { get => _region; set => SetValue(ref _region, value); }

        public event PropertyChangedEventHandler PropertyChanged;

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

        public void CopyFrom(Customer other)
        {
            Address = other.Address;
            City = other.City;
            CompanyName = other.CompanyName;
            ContactName = other.ContactName;
            ContactTitle = other.ContactTitle;
            Country = other.Country;
            ID = other.ID;
            Fax = other.Fax;
            Phone = other.Phone;
            PostalCode = other.PostalCode;
            Region = other.Region;
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

        private bool SetValue<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (object.Equals(storage, value))
                return false;

            storage = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
