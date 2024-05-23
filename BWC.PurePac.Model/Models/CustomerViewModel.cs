using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    
    public class CustomerVM
    {
        public virtual CustomerDetailVM CustomerDetail { get; set; }
        public virtual IList<CustomerPriceListVersion> CustomerPriceListVersions { get; set; }
        public CustomerVM(CustomerDetailVM customerDetail, IList<CustomerPriceListVersion> customerPriceListVersions)
        {
            CustomerDetail = customerDetail;
            CustomerPriceListVersions = customerPriceListVersions;
        }
    }
    public class CustomerDetailVM
    {
        public int ID { get; set; }
        public string SageCustomerRef { get; set; }
        public string CustomerName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public int AverageDaysToPay { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }

    public class CustomerPriceListVersion
    {
        public int? VersionNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual List<CustomerPriceListProduct> CustomerPriceListProducts { get; set; }
    }
    public class CustomerPriceListProduct
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string PartNumber { get; set; }
        public string PricingType { get; set; }
        public decimal? SellingPrice { get; set; }
        public int? ChangeType { get; set; }
    }
    public class AddCustomerVM
    {
        public string SageCustomerRef { get; set; }
        public int CreatedBy { get; set; }
    }
    public class CustomerSearchVM
    {
        public string SearchCriteria { get; set; }
    }
    public class CashFlowVM
    {
        public virtual CashFlowHeaderVM CashFlowHeader { get; set; }
        public virtual IList<CashFlowInvoiceVM> CashFlowInvoices { get; set; }
        public CashFlowVM(CashFlowHeaderVM cashflowHeader, IList<CashFlowInvoiceVM> cashflowInvoices)
        {
            CashFlowHeader = cashflowHeader;
            CashFlowInvoices = cashflowInvoices;
        }
    }
    public class CashFlowHeaderVM
    {
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public DateTime LastRefreshDateTime { get; set; }
        public string FormattedLastRefreshDateTime { get; set; }
    }
    public class CashFlowInvoiceVM
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public string InvoiceDetails { get; set; }
        public string FormattedInvoiceDate { get; set; }
        public string SageAccountRef { get; set; }
        public string CustomerName { get; set; }
        public int AverageDaysToPay { get; set; }
        public string InvoiceType { get; set; }
        public decimal InvoiceNET { get; set; }
        public decimal InvoiceTax { get; set; }
        public decimal InvoiceGross { get; set; }
        public DateTime CalculatedDueDate { get; set; }
        public string FormattedCalculatedDueDate { get; set; }
        public int CalculatedDueDateMonth { get; set; }
        public int CalculatedDueDateYear { get; set; }
        public bool NoAverageDaysToPay { get; set; }
        public decimal RunningTotal { get; set; }
    }
}