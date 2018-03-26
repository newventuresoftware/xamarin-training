using System;
using System.Collections.Generic;
using System.Text;
using XTraining.Models;

namespace XTraining.PageModels
{
    public class CustomerDetailsPageModel : FreshMvvm.FreshBasePageModel
    {
        private Customer customer;

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

        public override void Init(object initData)
        {
            SelectedCustomer = (Customer)initData;
        }
    }
}
