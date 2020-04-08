﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.BillsSetting
{
    public class Summation
    {
        //جدول المحصلين
        [Key]
        public int S_Id { get; set; }
        public virtual ICollection<Accounts.Customers> Customers { get; set; }
        public virtual ICollection<Accounts.Suppliers> Suppliers { get; set; }
        public virtual ICollection<LocalAccounts.Arresting_Voucher> Arresting_Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Returns> Purchases_Returns { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Commands> Purchases_Commands { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
        public virtual ICollection<Al_Sales.Sales_Returns> Sales_Returns { get; set; }
        public virtual ICollection<Al_Sales.ServiceSales_Invoice> ServiceSales_Invoices { get; set; }
        public virtual ICollection<Al_Sales.Prices_Displaies> Prices_Displaies { get; set; }
        public String S_Name { get; set; }
        public String Type { get; set; }
        public String Adddress { get; set; }
        public int Phone { get; set; }
        public String State { get; set; }
        public DateTime History { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int A_Id { get; set; }//رقم منطقة العمل 
        public virtual SalesAreas SalesAreas { get; set; }
        public int AccountId { get; set; }//في الدليل المحاسبي
        [ForeignKey("AccountId")]
        public virtual Accounts.ChartOfAccounts SummationAccountId { get; set; }

    }
}
