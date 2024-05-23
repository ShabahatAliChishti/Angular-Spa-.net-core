using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class ProductVM
    {
        public virtual ProductDetailVM ProductDetail { get; set; }
        public virtual IList<ProductStockDetailVM> StockList { get; set; }

        public ProductVM(ProductDetailVM productDetail, IList<ProductStockDetailVM> stockList)
        {
            ProductDetail = productDetail;
            StockList = stockList;
        }
    }
    public class ProductForecastVM
    {
        public virtual ProductForecastDetailVM ProductForecastDetail { get; set; }
        public virtual IList<ProductForecastOrderVM> ProductForecastOrderList { get; set; }

        public ProductForecastVM(ProductForecastDetailVM productForecastDetail, IList<ProductForecastOrderVM> orderList)
        {
            ProductForecastDetail = productForecastDetail;
            ProductForecastOrderList = orderList;
        }
    }
    public class ProductForecastDetailVM
    {
        public string SelectionText { get; set; }
        public int TotalQuantity { get; set; }
    }
    public class ProductForecastOrderVM
    {
        public string SageAccountRef { get; set; }
        public string CustomerName { get; set; }
        public string SalesOrderNumber { get; set; }
        public int LineNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderDateFormatted { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string AllocatedStatus { get; set; }
        public string DespatchStatus { get; set; }
        public string ProductCode { get; set; }
        public int QuantityOrder { get; set; }
        public int QuantityAllocated { get; set; }
        public int QuantityDelivered { get; set; }
    }
    public class GetProductPriceAnalysisVM
    {
        public string SageAccountRef { get; set; }
        public string ProductCode { get; set; }
    }
    public class GetProductCategoryAnalysisVM
    {
        public virtual IList<ProductCategorySelectionItem> ProductCategorySelectionList { get; set; }
        public string SageSupplierRef { get; set; }
        public string SageAccountRef { get; set; }
    }
    public class ProductCategorySelectionItem
    {
        public int id { get; set; }
        public string label { get; set; }
    }
    public class ProductCategoryDetailVM
    {
        public int ID { get; set; }
        public string ProductCategory { get; set; }
    }
    public class ForecastSelectionVM
    {
        public string ProductCode { get; set; }
        public string SelectionText { get; set; }
        public int MonthSelection { get; set; }
        public int YearSelection { get; set; }
        public string DateSelectionStart { get; set; }
        public string DateSelectionEnd { get; set; }
    }
    public class ProductStockDetailVM
    {
        public int ID { get; set; }
        public string ItemType { get; set; }
        public DateTime ItemDate { get; set; }
        public string FormattedDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerOrderReference { get; set; }
        public string SupplierName { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string FormattedOrderNumber { get; set; }
        public int Quantity { get; set; }
        public int QuantityOrdered { get; set; }
        public int Total { get; set; }
    }
   
    public class ProductPriceAnalysisDetailVM
    {
        public string SageAccountRef { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string StockCode { get; set; }
        public string ProductDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal TransactionCalcMargin { get; set; }
        public decimal SupplierCostPrice { get; set; }
        public decimal CustomerSpecialPrice { get; set; }
        public decimal CustomerPriceListPrice { get; set; }
        public decimal PriceListCalcMargin { get; set; }
    }
    public class ProductCategoryAnalysisVM
    {
        public virtual List<ProductCategoryAnalysisDetailVM> ProductCategoryAnalysisDetail { get; set; }
        public virtual List<ProductCategoryAnalysisSummaryVM> ProductCategoryAnalysisSummary { get; set; }
    }
    public class ProductCategoryAnalysisSummaryVM
    {
        public string SageAccountRef { get; set; }
        public string CustomerName { get; set; }
        public string ProductCategory { get; set; }
        public string StockCode { get; set; }
        public int NoInvoices { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal TransactionCalcMargin { get; set; }
        public decimal SupplierCostPrice { get; set; }
        public decimal CustomerSpecialPrice { get; set; }
        public decimal CustomerPriceListPrice { get; set; }
        public decimal PriceListCalcMargin { get; set; }
    }
    public class ProductCategoryAnalysisDetailVM
    {
        public string SageAccountRef { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string StockCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal TransactionCalcMargin { get; set; }
        public decimal SupplierCostPrice { get; set; }
        public decimal CustomerSpecialPrice { get; set; }
        public decimal CustomerPriceListPrice { get; set; }
        public decimal PriceListCalcMargin { get; set; }
    }
    public class ProductAllocationVM
    {
        public DateTime OrderDate { get; set; }
        public string OrderDateFormatted { get; set; }
        public String SageAccountRef { get; set; }
        public String SalesOrderNumber { get; set; }
        public int QuantityAllocated { get; set; }
    }
    public class ProductDetailVM
    {
        public int ID { get; set; }
        public int Supplier_ID { get; set; }
        public string SupplierName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategoryName { get; set; }
        public string PartNumber { get; set; }
        public decimal Weight { get; set; }
        public int Stock_InStock { get; set; }
        public int Stock_Allocated { get; set; }
        public string AllocatedOrderInfo { get; set; }
        public int Stock_Available { get; set; }
        public int QuantityOnOrder { get; set; }
        public int CustomerPending { get; set; }
        public decimal Price { get; set; }
        public decimal Cost_Price { get; set; }
        public string Location { get; set; }
        public int ReOrderLevel { get; set; }
        public int NETTAvailable { get; set; }
        public int ProductGroupingCategory_ID { get; set; }
        public string ProductGroupingCategory { get; set; }
    }
 
    public class GetProductDetailByVM
    {
        public int ProductID { get; set; }
        public bool IncludeQuotations { get; set; }
    }
}