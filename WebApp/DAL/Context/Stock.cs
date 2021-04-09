using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApi.Context
{
    public class Stock
    {
        public int StockId { get; set; }
        public int? Quantity { get; set; }
        public bool? CurrentStockItem { get; set; }
        public bool? CompleteStockItem { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public int ApplicationId { get; set; }
       
        public int ItemId { get; set; }
        public DateTime? CreatedDate{ get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Location { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
    }
}
