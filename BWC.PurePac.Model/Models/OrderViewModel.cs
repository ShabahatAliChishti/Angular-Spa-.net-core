using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class OrderVM
    {
        public virtual OrderHeaderVM OrderHeader{ get; set; }
        public virtual IList<OrderDetailVM> OrderDetails { get; set; }
        public virtual IList<AuditVM> AuditDetails { get; set; }

        public OrderVM(OrderHeaderVM orderHeader, IList<OrderDetailVM> orderDetails, IList<AuditVM> auditDetails)
        {
            OrderHeader = orderHeader;
            OrderDetails = orderDetails;
            AuditDetails = auditDetails;
        }
    }
    public class OrderListVM
    {
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string OrderReference { get; set; }
        public string SageACTReference { get; set; }
        public int OrderStatus_ID { get; set; }
        public string OrderStatus { get; set; }
        public int FirstOrderLine_Quantity { get; set; }
        public string FirstOrderLine_ProductCode { get; set; }
        public bool PartCompleted { get; set; }
    }
    public class OrderHeaderVM
    { 
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string OrderReference { get; set; }
        public string SageACTReference { get; set; }
        public int OrderStatus_ID { get; set; }
        public string OrderStatus { get; set; }
        public int DeliveryType_ID { get; set; }
        public string DeliveryType { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
    public class OrderDetailVM
    {
        public int ID { get; set; }
        public int OrderHeader_ID { get; set; }
        public int LineNumber { get; set; }
        public int Product_ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime RequiredDate { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool Completed { get; set; }
    }
    public class OrderAddCustomerVM
    {
        public int Customer_ID { get; set; }
        public string CustomerName { get; set; }
    }
    public class OrderAddHeaderVM
    {
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string OrderReference { get; set; }
        public string SageACTReference { get; set; }
        public int DeliveryType_ID { get; set; }
        public int CreatedBy { get; set; }
    }
    public class OrderAddDetailVM
    {
        public int Product_ID { get; set; }
        public string ProductCode { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime RequiredDate { get; set; }
    }    
    public class CompleteOrderDetailVM
    {
        public int OrderDetail_ID { get; set; }
        public int UpdatedBy { get; set; }
    }

    public class DeleteOrderDetailVM
    {
        public int OrderDetail_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class AddOrderVM
    {
        public virtual OrderAddCustomerVM OrderAddCustomerVM { get; set; }
        public virtual OrderAddHeaderVM OrderAddHeaderVM { get; set; }
        public virtual IList<OrderAddDetailVM> OrderAddDetailVM { get; set; }

        public AddOrderVM(OrderAddCustomerVM orderCustomer, OrderAddHeaderVM orderHeader, IList<OrderAddDetailVM> orderDetails)
        {
            OrderAddCustomerVM = orderCustomer;
            OrderAddHeaderVM = orderHeader;
            OrderAddDetailVM = orderDetails;
        }       
    }
    public class CancelOrderVM
    {
        public int Order_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class CompleteOrderVM
    {
        public int Order_ID { get; set; }
        public int OrderDetail_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class UnCompleteOrderVM
    {
        public int Order_ID { get; set; }
        public int OrderDetail_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class UpdOrderDetailVM
    {
        public int ID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime RequiredDate { get; set; }
        public string CustomerOrderReference { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class AddOrderDetailVM
    {
        public int OrderHeader_ID { get; set; }
        public int Product_ID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime RequiredDate { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class GetOrdersCalendarVM
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
    public class OrdersCalendarVM
    {
        public virtual IList<OrderCalendarVM> Day1 { get; set; }
        public virtual IList<OrderCalendarVM> Day2 { get; set; }
        public virtual IList<OrderCalendarVM> Day3 { get; set; }
        public virtual IList<OrderCalendarVM> Day4 { get; set; }
        public virtual IList<OrderCalendarVM> Day5 { get; set; }

        public OrdersCalendarVM(IList<OrderCalendarVM> day1, IList<OrderCalendarVM> day2, IList<OrderCalendarVM> day3, IList<OrderCalendarVM> day4, IList<OrderCalendarVM> day5)
        {
            Day1 = day1;
            Day2 = day2;
            Day3 = day3;
            Day4 = day4;
            Day5 = day5;
        }
    }
    public class OrderCalendarVM
    {
        public int? ID { get; set; }
        public int? OrderHeader_ID { get; set; }
        public int? Customer_ID { get; set; }
        public string CustomerName { get; set; }       
        public DateTime? OrderDate { get; set; }
        public string OrderDateFormatted { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string RequiredDateFormatted { get; set; }
        public string OrderReference { get; set; }
        public string SageACTReference { get; set; }
        public int? OrderStatus_ID { get; set; }
        public string OrderStatus { get; set; }
        public int? DeliveryType_ID { get; set; }
        public string DeliveryType { get; set; }
        public virtual List<OrderCalendarDetailVM> DetailInfo { get; set; }
        public int? DeliverySlotHour { get; set; }
        public string DeliverySlotFormatted { get; set; }
        public bool DeliverySlotAllocated { get; set; }
        public string DeliverySlotNote { get; set; }
        public string DeliverySlotVehicle { get; set; }
        public string DeliverySlotDriver { get; set; }
    }
    public class OrderCalendarDetailVM
    {
        public int? ID { get; set; }
        public int? OrderHeader_ID { get; set; }
        public int? LineNumber { get; set; }
        public int? Product_ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int? OrderQuantity { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string RequiredDateFormatted { get; set; }
    }
    public class AddEditOrderDeliverySlotVM
    {
        public int OrderHeader_ID { get; set; }
        public int DeliverySlotHour { get; set; }
        public string DeliverySlotVehicle { get; set; }
        public string DeliverySlotDriver { get; set; }
        public string DeliverySlotNote { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class DeliveryTypeVM
    {
        public int ID { get; set; }
        public string DeliveryType { get; set; }
    }
}