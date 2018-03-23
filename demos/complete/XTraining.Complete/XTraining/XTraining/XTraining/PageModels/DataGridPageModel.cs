using System;
using System.Collections.Generic;
using System.Text;
using XTraining.Models;

namespace XTraining.PageModels
{
    public class DataGridPageModel : FreshMvvm.FreshBasePageModel
    {
        public DataGridPageModel(Services.INorthwindService northwindService)
        {
            this.northwindService = northwindService;
        }

        private IList<Order> orders;
        private Services.INorthwindService northwindService;

        public IList<Order> Orders
        {
            get => this.orders;
            private set
            {
                if (this.orders == value)
                    return;

                this.orders = value;
                RaisePropertyChanged();
            }
        }

        public async override void Init(object initData)
        {
            base.Init(initData);

            if (Orders == null)
            {
                Orders = await northwindService.GetOrdersAsync();
            }
        }
    }
}
