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
        public string CustomerID { get; set; }

        [DisplayOptions(Header = "Fax")]
        public string Fax { get; set; }

        [DisplayOptions(Header = "Phone")]
        public string Phone { get; set; }

        [DisplayOptions(Header = "PO Code")]
        public string PostalCode { get; set; }

        [DisplayOptions(Header = "Region")]
        public string Region { get; set; }
    }
}
