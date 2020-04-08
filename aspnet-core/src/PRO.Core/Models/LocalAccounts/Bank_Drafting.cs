﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class Bank_Drafting
    {
        //السحب البنكي

        //  التوريد البنكي
        //سند القيض
        //Top
        [Key]
        public int Move_Id { get; set; }

        public DateTime Vou_History { get; set; }
        public int BT_Id { get; set; }
        public virtual Editorial_Accounts.Bonds_Types Bonds_Types { get; set; }
        public string BT_Name { get; set; }
        public int M_Id { get; set; }
        public virtual Accounts.Currency Currency { get; set; }
        public string M_Name { get; set; }
        public int TransferPrice { get; set; }//سعر الصرف
        public bool Const_Comment { get; set; }



        //Select Cheque
        public int Bnk_Id { get; set; }
        public virtual Accounts.Banks Banks { get; set; }
        public string Bnk_Name { get; set; }
        public string Ch_Communique { get; set; }
        public int Reffe_Id { get; set; }
        public string Deposited_Name { get; set; }//اسم المودع
        public int S_Id { get; set; }
        public virtual BillsSetting.Summation Summation { get; set; }
        public string S_Name { get; set; }
        public int Ch_Id { get; set; }
        public string Ch_Type { get; set; }
        public virtual Editorial_Accounts.Cheque_Type Cheque_Type { get; set; }
        public DateTime Deservedness_History { get; set; }//تاريخ الاستحقاق
        public string Ch_Details { get; set; }//تفاصيل الشيك



        //Lower

        public int Account_Id { get; set; }
        public virtual Accounts.ChartOfAccounts ChartOfAccounts { get; set; }
        public string Account_Name { get; set; }
        public string A_Communique { get; set; }
        public string C_Name { get; set; }
        public int Sup_Id { get; set; }
        public virtual Accounts.Suppliers Suppliers { get; set; }
        public string Sup_Name { get; set; }
        public string Communique { get; set; }
        public double Debtor { get; set; }//المبلغ بالنسبة للمدين
        public double Equivalent { get; set; }// المكافئ
        public DateTime History { get; set; }
     
    }
}
