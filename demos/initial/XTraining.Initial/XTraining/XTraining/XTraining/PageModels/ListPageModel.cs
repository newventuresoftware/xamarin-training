using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        }

        private ObservableCollection<Customer> customers;
        private Services.INorthwindService northwindService;

        public ObservableCollection<Customer> Customers
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

        public async override void Init(object initData)
        {
            base.Init(initData);

            if (Customers == null)
            {
                Customers = new ObservableCollection<Customer>(await northwindService.GetCustomersAsync());
            }
        }
    }
}
