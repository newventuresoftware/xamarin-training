using System;

namespace XTraining.PageModels
{
    public class ChartPageModel : FreshMvvm.FreshBasePageModel
    {
        public ChartPageModel(Services.INorthwindService northwindService)
        {
            this.northwindService = northwindService;
        }

        private Services.INorthwindService northwindService;

        // TODO: Add content
    }
}
