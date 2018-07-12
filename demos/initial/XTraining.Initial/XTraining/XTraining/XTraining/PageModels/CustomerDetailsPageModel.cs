using System;

namespace XTraining.PageModels
{
    public class CustomerDetailsPageModel : FreshMvvm.FreshBasePageModel
    {
        public CustomerDetailsPageModel(Services.INorthwindService northwindService)
        {
            this.northwindService = northwindService;
        }

        private Services.INorthwindService northwindService;

        // TODO: Add content
    }
}