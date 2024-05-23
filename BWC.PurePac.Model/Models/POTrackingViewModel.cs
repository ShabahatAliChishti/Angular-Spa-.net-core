using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class GetPOTrackingVM
    {
        public int Status { get; set; }        
    }
    
    public class POTrackingVM
    {
        public string PurchaseorderNumber { get; set; }
		public string SupplierOrderNumber { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityOrder { get; set; }
        public int QuantityAllocated { get; set; }
        public int QuantityDelivered { get; set; }
        public int CalculatedQuantity { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string WeekCommencing { get; set; }
        public string DeliveryDateFormatted { get; set; }
        public int YearNumber { get; set; }
        public int WeekNumber { get; set; }

    }
}