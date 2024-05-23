using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class MappingSearchVM
    {
        public string AccountSearch { get; set; }
        public string AccountType { get; set; }
        public string chkRAG_Red { get; set; }
        public string chkRAG_Amber { get; set; }
        public string chkRAG_Green { get; set; }
        public string Orders { get; set; }
    }
    public class GetGeocodingForAddressVM
    {
        public string AddressOrPostCode { get; set; }
    }
    public class MappingSearchPlottingVM
    {
        public string AccountType { get; set; }
        public int PlotRadius { get; set; }        
    }
    public class GeoCodeAddressVM
    {
        public string AddressOrPostCode { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string FormattedAddress { get; set; }
        public bool AddressInvalid { get; set; }
    }
    public class AddressDetailVM
    {
        public int ID { get; set; }
        public string LinkType { get; set; }
        public string Customer_AccountRef { get; set; }
        public string Customer_Name { get; set; }
        public string Supplier_AccountRef { get; set; }
        public string Supplier_Name { get; set; }
        public string AddressRef { get; set; }
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string AddressFormatted { get; set; }
        public string AccountRefFormatted { get; set; }
        public string AddressType { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public DateTime? Supplier_FirstOrderDate { get; set; }
        public DateTime? Supplier_LastOrderDate { get; set; }
        public int? Supplier_NumOrders { get; set; }
        public int? Supplier_AverageOrderFrequency { get; set; }
        public DateTime? Customer_FirstOrderDate { get; set; }
        public DateTime? Customer_LastOrderDate { get; set; }
        public int? Customer_NumOrders { get; set; }
        public int? Customer_AverageOrderFrequency { get; set; }
        public DateTime? FirstOrderDate { get; set; }
        public DateTime? LastOrderDate { get; set; }
        public int? NumOrders { get; set; }
        public int? AverageOrderFrequency { get; set; }
        public int? DaysAgo { get; set; }
        public string RAGStatus { get; set; }
        public virtual LastOrderInfo LastOrderInfo { get; set; }
    }
}