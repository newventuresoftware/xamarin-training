using System;
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
            this.cancelCommand = new Command(OnCancel);
        }

        private Customer originalCustomer, draftCustomer;
        private Command saveCommand, cancelCommand;
        private Services.INorthwindService northwindService;

        public Customer DraftCustomer
        {
            get => this.draftCustomer;
            set
            {
                if (this.draftCustomer == value)
                    return;

                this.draftCustomer = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SaveCommand => this.saveCommand;
        public ICommand CancelCommand => this.cancelCommand;

        public override void Init(object initData)
        {
            originalCustomer = (Customer)initData;
            DraftCustomer = originalCustomer.Clone();
        }

        private async void OnSave(object obj)
        {
            Customer draftCustomer = this.DraftCustomer;
            if (draftCustomer.Equals(originalCustomer))
                return;

            bool result = await this.northwindService.UpdateCustomer(draftCustomer);

            if (result)
            {
                originalCustomer.CopyFrom(draftCustomer);
            }

            string resultStr = result ? "successfully" : "unsuccessfully";
            await CoreMethods.DisplayAlert("Customer Update", $"Customer updated {resultStr}", "OK");

            await this.CoreMethods.PopPageModel(true);
        }

        private void OnCancel(object obj)
        {
            this.CoreMethods.PopPageModel(true);
        }
    }
}
