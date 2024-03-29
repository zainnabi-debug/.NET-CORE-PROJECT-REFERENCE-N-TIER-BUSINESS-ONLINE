﻿using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.CRM.Tables
{
    [Table("Customers")]
    public class Customers
    {
        [Dapper.Contrib.Extensions.Key]
        public int CustomerID { get; set; }

        public string AccountCode { get; set; }
        public int BranchID { get; set; }

        [DisplayName("Status")]
        public int? CustomerStatusID { get; set; }
        public string Name { get; set; }
        public bool LinkedAccount { get; set; }
        public int? LinkedCustomerID { get; set; }
        public bool FWSystemAccount { get; set; }
        public bool InternalAccount { get; set; }
         [DisplayName("Last Increased")]  
        public DateTime? LastIncreaseDate { get; set; }
         [DisplayName("Next Increase")]
        public DateTime? NextIncreaseDate { get; set; }
        public string Contact { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string CellNo { get; set; }
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        public string AddLine3 { get; set; }
        public string AddLine4 { get; set; }
        public string PostalCode { get; set; }
        public bool? MarkforClosure { get; set; }
        public int? StatusID { get; set; }
        public int CustomerAccountTypeID { get; set; }
        public string FWRateAccCode { get; set; }
        public string FWRepCode { get; set; }
        public bool? HasUniques { get; set; }
        public decimal? Insurance { get; set; }
        public int VolRatio { get; set; }
        public string Swat { get; set; }
        public decimal? Avg { get; set; }
        public decimal? Compliance { get; set; }
        public int? RateClassID { get; set; }
         [DisplayName("Created")]
        public DateTime? AccountCreatedDate { get; set; }
        public decimal? SixMonthCompliance { get; set; }
        public int? InternalDepartmentID { get; set; }
        public string RevisedAnvDate { get; set; }
        public bool Exclusion { get; set; }
        public bool hasFuelOnSundries { get; set; }
        public string PropAddress1 { get; set; }
        public string PropAddress2 { get; set; }
        public string PropAddress3 { get; set; }
        public string PropAddress4 { get; set; }
        public string PropTel { get; set; }
        public string PropFax { get; set; }
        public string PropPostalCode { get; set; }
        public int CustomerCommisionTypeID { get; set; }
        public bool hasFixedPerc { get; set; }
        public decimal? FixedPerc { get; set; }
        public int? PaymentProfileID { get; set; }
        public bool ExcludeTargetCorrection { get; set; }
        public bool? PODVerify { get; set; }
        public int? VerticalMarketID { get; set; }
        public int? SubVerticalMarketID { get; set; }
        public int? CustomerTradeStatusID { get; set; }
        public int? SaleTypeID { get; set; }

        [Computed]
        public string CustomerName => AccountCode + " - " + Name;

        public bool? ExcludeFromDeliveries { get; set; }
        public int FuelSurchargeClassID { get; set; }
        public string FWCreditController { get; set; }
        public int? CreditControllerEmployeeID { get; set; }
        public string Country { get; set; }
        public string StatementEmailAdd  { get; set; }
        public bool? isDelayed { get; set; }
        public string FWPriceCheckQuoteNo { get; set; }

        public string CustomerAccountCodeName { get; set; }
    }
}
