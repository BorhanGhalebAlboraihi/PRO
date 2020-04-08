﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Services_Groupes
    {
        //المجموعات الخدمبة
        [Key]
        public int SG_Id { get; set; }
        public virtual ICollection<Categores.Categores_Data> Categores_Datas { get; set; }
        public string SG_Name { get; set; }
        public int S_Id { get; set; }
        public virtual Stores Stores { get; set; }
        public string S_Name { get; set; }
        public int Account_Id { get; set; }
        public virtual Accounts.ChartOfAccounts ChartOfAccounts { get; set; }
        public string Account_Name { get; set; }
        public string Type { get; set; }
        public string History { get; set; }
        public string CS_Name { get; set; }
        public virtual Categores.Cat_State Cat_State { get; set; }
        public string Rank { get; set; }
    }
}
