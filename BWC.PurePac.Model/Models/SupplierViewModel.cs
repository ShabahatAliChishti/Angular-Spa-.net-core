using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class SupplierVM
    {
        public virtual SupplierDetailVM SupplierDetail { get; set; }
        public virtual IList<SupplierProductVM> SupplierProducts { get; set; }
        public virtual IList<SupplierPriceListVM> SupplierPriceLists { get; set; }
        public virtual IList<SupplierCustomerPriceListCustomerVM> SupplierCustomerPriceLists { get; set; }
        public SupplierVM(SupplierDetailVM supplierDetail, IList<SupplierProductVM> supplierProducts, IList<SupplierPriceListVM> supplierPriceLists, IList<SupplierCustomerPriceListCustomerVM> supplierCustomerPriceLists)
        {
            SupplierDetail = supplierDetail;
            SupplierProducts = supplierProducts;
            SupplierPriceLists = supplierPriceLists;
            SupplierCustomerPriceLists = supplierCustomerPriceLists;
        }
    }
    public class SupplierDetailVM
    {
        public int ID { get; set; }
        public string SageSupplierRef { get; set; }
        public string SupplierName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 {     get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public Boolean TrackPricing { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
    
    public class SupplierPriceListVM
    {
        public int SequenceNumber { get; set; }
        public string SelectListText { get; set; }
        public virtual SupplierPriceListHeaderVM SupplierPriceListHeader {get;set;}
        public virtual List<SupplierPriceListDetailVM> SupplierPriceListDetails { get; set; }
    }
    public class SupplierCustomerPriceListCustomerVM
    {
        public int? Customer_ID { get; set; }
        public string CustomerName { get; set; }
        public virtual List<SupplierCustomerPriceListVersion> SupplierCustomerPriceListVersions { get; set; }
    }
    public class SupplierCustomerPriceListVersion
    {
        public int? VersionNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual List<SupplierCustomerPriceListProduct> SupplierCustomerPriceListProducts { get; set; }
    }
    public class SupplierCustomerPriceListProduct
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string PartNumber { get; set; }
        public string PricingType { get; set; }
        public decimal? SellingPrice { get; set; }
        public int? ChangeType { get; set; }
    }
    public class SupplierPriceListHeaderVM
    {
        public int ID { get; set; }
        public int? Supplier_ID { get; set; }
        public int? VersionNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
    public class SupplierPriceListDetailVM
    {
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string PartNumber { get; set; }
        public decimal? CostPrice { get; set; }
        public int? ChangeType { get; set; }        
    }
    public class SupplierProductVM
    {
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategoryName { get; set; }
        public string PartNumber { get; set; }
        public decimal Weight { get; set; }
        public int Stock_InStock { get; set; }
        public int Stock_Allocated { get; set; }
        public int QuantityOnOrder { get; set; }
        public decimal Price { get; set; }
        public decimal Cost_Price { get; set; }
        public string Location { get; set; }
    }
    public class UpdSupplierTrackPricingVM
    {
        public int ID { get; set; }
        public Boolean TrackPricing { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class AddSupplierVM
    {
        public string SageSupplierRef { get; set; }
        public Boolean TrackPricing { get; set; }
        public int CreatedBy { get; set; }
    }
}