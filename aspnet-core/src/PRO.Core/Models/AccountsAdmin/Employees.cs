﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Employees
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public int Emp_MainAccountNB { get; set; }
        public string Emp_Netural { get; set; }
        public string Emp_address { get; set; }
        public int Emp_Card { get; set; }
        public int Emp_Phone { get; set; }
        public string Emp_State { get; set; }
        public string Emp_Rank { get; set; }
        public double Emp_Salery { get; set; }
        public string Emp_Job { get; set; }
        public string Emp_Center { get; set; }//فرع الموظف
        public string Emp_Qualification { get; set; }
        public string Emp_PushingMethod { get; set; }//طريقة الدفع شهري سنوي 
        public DateTime Emp_History { get; set; }
        public int Emp_BankAccountNB { get; set; }//رقم الحساب البنكي
        public string Emp_WorkArea { get; set; }//مكان العمل
        public string Emp_Country{ get; set; }
        public string Emp_City { get; set; }
        public string Emp_CostCenter { get; set; }
        public String Emp_InclusionName { get; set; }//اسم الضمين
        public int Emp_InclusionNB { get; set; }
        public int Emp_HistoryEnd { get; set; }
        public int Emp_InclusionCard { get; set; }
        public DateTime Emp_WStateHis{ get; set; }//تاريخ بدء العمل
        public int Emp_WorkTime { get; set; }
        /// <summary>
        /// فترة العمل للموظف
        /// </summary>
        public string M_Name { get; set; } 
        public virtual Currency Currency { get; set; }
        public int A_Id { get; set; }
        public virtual BillsSetting.SalesAreas SalesAreas { get; set; }
        public int AccountId { get; set; }
        [ ForeignKey("AccountId")]
        public virtual ChartOfAccounts EmpAccountId { get; set; }
        /// <summary>
        /// Relationship
        /// </summary>
        public virtual ICollection<BillsSetting.Employee_Lower> Employee_Lowers { get; set; }
        public virtual ICollection<Categores_and_Stores.Categores.Breakage_Categores> Breakage_Categores { get; set; }
        public virtual ICollection<LocalAccounts.Employees_Activity> Employees_Activities { get; set; }
        public virtual ICollection<LocalAccounts.Salerys_Execution> Salerys_Executions { get; set; }
        public virtual ICollection<Junctures_Sales_System.Junctures_Add> Junctures_Adds { get; set; }








    }
}
