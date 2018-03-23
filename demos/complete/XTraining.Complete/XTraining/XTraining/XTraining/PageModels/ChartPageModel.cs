using System.Collections.Generic;
using System.Linq;
using XTraining.Models;

namespace XTraining.PageModels
{
    public class ChartPageModel : FreshMvvm.FreshBasePageModel
    {
        public ChartPageModel(Services.INorthwindService northwindService)
        {
            this.northwindService = northwindService;
        }

        private IList<Product> data;
        private Services.INorthwindService northwindService;

        public IList<Product> Data
        {
            get => this.data;
            set
            {
                if (this.data == value)
                    return;

                this.data = value;
                RaisePropertyChanged();
            }
        }

        public async override void Init(object initData)
        {
            base.Init(initData);

            if (Data == null)
            {
                var rawData = await northwindService.GetProductsAsync(10);
                if (rawData != null)
                    Data = rawData.OrderBy(c => c.UnitPrice).ToArray();
            }
        }

        private IList<CategoricalData> CreateSampleData()
        {
            List<CategoricalData> newData = new List<CategoricalData>()
            {
                new CategoricalData() { Category = "A", Value = 1 },
                new CategoricalData() { Category = "B", Value = 2 },
                new CategoricalData() { Category = "C", Value = 3 },
            };
            return newData;
        }
    }
}
