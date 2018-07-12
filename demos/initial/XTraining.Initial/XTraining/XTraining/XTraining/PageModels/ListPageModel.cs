using System;

namespace XTraining.PageModels
{
    public class ListPageModel : FreshMvvm.FreshBasePageModel
    {
        public ListPageModel(Services.INorthwindService northwindService)
        {
            this.northwindService = northwindService;
        }

        private Services.INorthwindService northwindService;

        // TODO: Add content
    }
}
