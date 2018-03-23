using Newtonsoft.Json;

namespace XTraining.Models
{
    public class Product
    {
        public int? CategoryID { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool Discontinued { get; set; }
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short? ReorderLevel { get; set; }
        public int? SupplierID { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
    }
}
