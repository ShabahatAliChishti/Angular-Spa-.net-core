using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    
    public class OrderHistoryListVM
    {
        public string SageAccountRef { get; set; }
        public string CompanyType { get; set; }
        public string Name { get; set; }
        public DateTime? FirstOrderDate { get; set; }
        public DateTime? LastOrderDate { get; set; }
        public int? NumOrders { get; set; }
        public int? AverageOrderFrequency { get; set; }
        public int? DaysAgo { get; set; }
        public string RAGStatus { get; set; }
        public virtual LastOrderInfo LastOrderInfo { get; set; }
        public virtual List<ACTOrder> ACTOrderInfo { get; set; }
    }
    public class ACTOrder
    {
        public string ACT_CompanyID { get; set; }
        public string OpportunityID { get; set; }
        public string OrderType { get; set; }
        public DateTime OpenDate { get; set; }
        public string OpenDateFormatted { get; set; }
        public string OrderDescription { get; set; }
        public DateTime RequiredDelDate { get; set; }
        public string RequiredDelDateFormatted { get; set; }
        public decimal OrderValue { get; set; }
    }

    public class LastOrderInfo
    {
        public string SageAccountRef { get; set; }
        public string SalesOrderNumber { get; set; }
        public int LineNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderDateFormatted { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string AllocatedStatus { get; set; }
        public string DespatchStatus { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityOrder { get; set; }
        public int QuantityAllocated { get; set; }
        public int QuantityDelivered { get; set; }
    }
    public class OrderHistoryListParams
    {
        public string ShowCompanyType { get; set; }
        public bool HideNeverOrdered { get; set; }
        public int HideOrderedOver { get; set; }
        public bool ShowRAG_Red { get; set; }
        public bool ShowRAG_Amber { get; set; }
        public bool ShowRAG_Green { get; set; }
    }
}