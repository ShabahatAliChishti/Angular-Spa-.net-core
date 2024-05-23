using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class PurchaseOrderVM
    {
        public virtual PurchaseOrderHeaderVM PurchaseOrderHeader { get; set; }
        public virtual IList<PurchaseOrderDetailVM> PurchaseOrderDetails { get; set; }

        public PurchaseOrderVM(PurchaseOrderHeaderVM purchaseorderHeader, IList<PurchaseOrderDetailVM> purchaseorderDetails)
        {
            PurchaseOrderHeader = purchaseorderHeader;
            PurchaseOrderDetails = purchaseorderDetails;
        }
    }
    public class PurchaseOrderHeaderVM
    {
        public int ID { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public int Supplier_ID { get; set; }
        public string SupplierName { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderDateFormatted { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryDateFormatted { get; set; }
        public string OrderStatusCode { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryStatusCode { get; set; }
        public string DeliveryStatus { get; set; }
        public string SupplierOrderNumber { get; set; }
    }
    public class PurchaseOrderDetailVM
    {
        public int ID { get; set; }
        public int POHdr_ID { get; set; }
        public int LineNumber { get; set; }
        public int Product_ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityOrder { get; set; }
        public int QuantityAllocated { get; set; }
        public int QuantityDelivered { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryDateFormatted { get; set;  }
    }
}