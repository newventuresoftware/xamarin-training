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

        private IList<CategoricalData> data;
        private Services.INorthwindService northwindService;

        public IList<CategoricalData> Data
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

        public override void Init(object initData)
        {
            base.Init(initData);

            if (Data == null)
            {
                Data = CreateSampleData();
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
