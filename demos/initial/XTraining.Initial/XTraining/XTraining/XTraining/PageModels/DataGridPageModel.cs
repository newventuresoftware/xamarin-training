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

        private Services.INorthwindService northwindService;

        public override void Init(object initData)
        {
            base.Init(initData);

            // TODO: Get Orders from Northwind
        }
    }
}
