using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class QuotationVM
    {
        public virtual QuotationHeaderVM QuotationHeader{ get; set; }
        public virtual IList<QuotationDetailVM> QuotationDetails { get; set; }
        public virtual IList<AuditVM> AuditDetails { get; set; }

        public QuotationVM(QuotationHeaderVM quotationHeader, IList<QuotationDetailVM> quotationDetails, IList<AuditVM> auditDetails)
        {
            QuotationHeader = quotationHeader;
            QuotationDetails = quotationDetails;
            AuditDetails = auditDetails;
        }
    }
    public class QuotationListVM
    {
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuotationDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string QuotationReference { get; set; }
        public string SageACTReference { get; set; }
        public int QuotationStatus_ID { get; set; }
        public string QuotationStatus { get; set; }
        public int FirstQuotationLine_Quantity { get; set; }
        public string FirstQuotationLine_ProductCode { get; set; }
        public bool PartCompleted { get; set; }
    }
    public class QuotationHeaderVM
    { 
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuotationDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string QuotationReference { get; set; }
        public string SageACTReference { get; set; }
        public int QuotationStatus_ID { get; set; }
        public string QuotationStatus { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
    public class QuotationDetailVM
    {
        public int ID { get; set; }
        public int QuotationHeader_ID { get; set; }
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
    public class QuotationAddHeaderVM
    {
        public DateTime QuotationDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string QuotationReference { get; set; }
        public string SageACTReference { get; set; }
        public int CreatedBy { get; set; }
    }
    public class QuotationAddDetailVM
    {
        public int Product_ID { get; set; }
        public string ProductCode { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime RequiredDate { get; set; }
    }
    public class QuotationAddCustomerVM
    {
        public int Customer_ID { get; set; }
        public string CustomerName { get; set; }
    }
    public class CompleteQuotationDetailVM
    {
        public int QuotationDetail_ID { get; set; }
        public int UpdatedBy { get; set; }
    }

    public class DeleteQuotationDetailVM
    {
        public int QuotationDetail_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class AddQuotationVM
    {
        public virtual QuotationAddCustomerVM QuotationAddCustomerVM { get; set; }
        public virtual QuotationAddHeaderVM QuotationAddHeaderVM { get; set; }
        public virtual IList<QuotationAddDetailVM> QuotationAddDetailVM { get; set; }

        public AddQuotationVM(QuotationAddCustomerVM quotationCustomer, QuotationAddHeaderVM quotationHeader, IList<QuotationAddDetailVM> quotationDetails)
        {
            QuotationAddCustomerVM = quotationCustomer;
            QuotationAddHeaderVM = quotationHeader;
            QuotationAddDetailVM = quotationDetails;
        }       
    }
    public class CancelQuotationVM
    {
        public int Quotation_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class CompleteQuotationVM
    {
        public int Quotation_ID { get; set; }
        public int QuotationDetail_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class UnCompleteQuotationVM
    {
        public int Quotation_ID { get; set; }
        public int QuotationDetail_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class UpdQuotationDetailVM
    {
        public int ID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime RequiredDate { get; set; }
        public string QuotationReference { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class AddQuotationDetailVM
    {
        public int QuotationHeader_ID { get; set; }
        public int Product_ID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime RequiredDate { get; set; }
        public int UpdatedBy { get; set; }
    }
}