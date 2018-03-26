using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XTraining.Models;

namespace XTraining.PageModels
{
    public class ListPageModel : FreshMvvm.FreshBasePageModel
    {
        public ListPageModel(Services.INorthwindService northwindService)
        {
            this.northwindService = northwindService;
            this.deleteCommand = new Command<Customer>(DeleteCustomer);
        }

        private IList<Customer> customers;
        private Customer selectedCustomer;
        private Services.INorthwindService northwindService;
        private Command<Customer> deleteCommand;

        public ICommand DeleteCommand => deleteCommand;

        public IList<Customer> Customers
        {
            get => this.customers;
            private set
            {
                if (this.customers == value)
                    return;

                this.customers = value;
                RaisePropertyChanged();
            }
        }

        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                if (selectedCustomer == value)
                    return;

                this.selectedCustomer = value;
                RaisePropertyChanged();
                OnSelectedCustomerChanged(value);
            }
        }

        public async override void Init(object initData)
        {
            base.Init(initData);

            if (Customers == null)
            {
                Customers = await northwindService.GetCustomersAsync();
            }
        }

        private void OnSelectedCustomerChanged(Customer customer)
        {
            if (customer == null)
                return;

            this.SelectedCustomer = null;
            CoreMethods.PushPageModel<CustomerDetailsPageModel>(customer, false, true);
        }

        private async void DeleteCustomer(Customer customer)
        {
            bool result = await this.northwindService.DeleteCustomer(customer);
            string resultStr = result ? "successfully" : "unsuccessfully";
            await CoreMethods.DisplayAlert("Customer Update", $"Customer updated {resultStr}", "OK");
        }
    }
}
