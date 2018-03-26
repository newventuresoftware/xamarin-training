using System.Windows.Input;
using Xamarin.Forms;
using XTraining.Models;

namespace XTraining.PageModels
{
    public class CustomerDetailsPageModel : FreshMvvm.FreshBasePageModel
    {
        public CustomerDetailsPageModel(Services.INorthwindService northwindService)
        {
            this.northwindService = northwindService;
            this.saveCommand = new Command(OnSave);
        }

        private Customer originalCustomer, customer;
        private Command saveCommand;
        private Services.INorthwindService northwindService;

        public Customer SelectedCustomer
        {
            get => this.customer;
            set
            {
                if (this.customer == value)
                    return;

                this.customer = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SaveCommand => this.saveCommand;

        public override void Init(object initData)
        {
            originalCustomer = (Customer)initData;
            SelectedCustomer = originalCustomer.Clone();
        }

        private async void OnSave(object obj)
        {
            if (SelectedCustomer.Equals(originalCustomer))
                return;

            bool result = await this.northwindService.UpdateCustomer(SelectedCustomer);
            string resultStr = result ? "successfully" : "unsuccessfully";
            await CoreMethods.DisplayAlert("Customer Update", $"Customer updated {resultStr}", "OK");
        }
    }
}
