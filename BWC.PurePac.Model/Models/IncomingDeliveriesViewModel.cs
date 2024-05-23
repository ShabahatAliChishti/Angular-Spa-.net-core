using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class GetIncomingDeliveriesVM
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
    public class AddEditDeliverySlotVM
    {
        public int POHdr_ID { get; set; }
        public int DeliverySlotHour { get; set; }
        public string DeliverySlotNote { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class AddEditManualDeliverySlotVM
    {
        public int ManualDelivery_ID { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string SupplierName { get; set; }
        public int DeliverySlotHour { get; set; }
        public string DeliverySlotNote { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class IncomingDeliveriesVM
    {
        public virtual IList<IncomingDeliveryVM> Day1 { get; set; }
        public virtual IList<IncomingDeliveryVM> Day2 { get; set; }
        public virtual IList<IncomingDeliveryVM> Day3 { get; set; }
        public virtual IList<IncomingDeliveryVM> Day4 { get; set; }
        public virtual IList<IncomingDeliveryVM> Day5 { get; set; }

        public IncomingDeliveriesVM(IList<IncomingDeliveryVM> day1, IList<IncomingDeliveryVM> day2, IList<IncomingDeliveryVM> day3, IList<IncomingDeliveryVM> day4, IList<IncomingDeliveryVM> day5)
        {
            Day1 = day1;
            Day2 = day2;
            Day3 = day3;
            Day4 = day4;
            Day5 = day5;
        }
    }
    public class IncomingDeliveryVM
    {
        public int? ID { get; set; }
        public int? POHdr_ID { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public int? Supplier_ID { get; set; }
        public string SupplierName { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderDateFormatted { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryDateFormatted { get; set; }
        public string SupplierOrderNumber { get; set; }
        public virtual List<IncomingDeliveryDetail> DetailInfo { get; set; }
        public int? DeliverySlotHour { get; set; }
        public string DeliverySlotFormatted { get; set; }
        public bool DeliverySlotAllocated { get; set; }
        public string DeliverySlotNote { get; set; }
        public decimal? TotalNetAmount { get; set; }
        public decimal? TotalGrossAmount { get; set; }
    }
    public class IncomingDeliveryDetail
    {
        public int? ID { get; set; }
        public int? POHdr_ID { get; set; }
        public int? LineNumber { get; set; }
        public int? Product_ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int? QuantityOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public int? QuantityDelivered { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? GrossAmount { get; set; }
    }
}