using System;

namespace XTraining.PageModels
{
    public class DataGridPageModel : FreshMvvm.FreshBasePageModel
    {
        public DataGridPageModel(Services.INorthwindService northwindService)
        {
            this.northwindService = northwindService;
        }

        private Services.INorthwindService northwindService;

        // TODO: Add content
    }
}
