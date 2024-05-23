using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class AuditVM
    {
        public int ID { get; set; }
        public string LinkType { get; set; }
        public int Link_ID { get; set; }
        public int User_ID { get; set; }
        public string SecSecurityLogonLogonName { get; set; }
        public string AuditDescription { get; set; }
        public string ObjPreviousState { get; set; }
        public string ObjPresentState { get; set; }
        public string ObjChangedFlds { get; set; }
        public string AuditObjType { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public IList<AuditFieldDifferences> ChangedFieldsList { get; set; }
    }
    public class AuditFieldDifferences
    {
        public string FldName { get; set; }
        public string BeforeValue { get; set; }
        public string AfterValue { get; set; }

        public AuditFieldDifferences() { }

        //custom constructor
        public AuditFieldDifferences(string fldName, string beforeValue, string afterValue)
        {
            FldName = fldName;
            BeforeValue = beforeValue;
            AfterValue = afterValue;
        }
    }
    public class Audit_OrderHeaderVM
    {
        public int ID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderReference { get; set; }
        public DateTime? RequiredDate { get; set; }
        public int? DeliveryType_ID { get; set; }
        public string DeliveryType { get; set; }
    }
    public class Audit_QuotationHeaderVM
    {
        public int ID { get; set; }
        public DateTime? QuotationDate { get; set; }
        public string QuotationReference { get; set; }
        public DateTime? RequiredDate { get; set; }
    }
    public class Audit_OrderDetailVM
    {
        public int ID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime? RequiredDate { get; set; }
    }
    public class Audit_QuotationDetailVM
    {
        public int ID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime? RequiredDate { get; set; }
    }
    public class Audit_LoginVM
    {
        public string UserID { get; set; }
        public string IP_Address { get; set; }
        public string GeoLocationInformation { get; set; }
        public string UserAgent { get; set; }
    }
}