//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ims_mat_pro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblreturnHistoryDetail
    {
        public int id { get; set; }
        public Nullable<int> issueRetailId { get; set; }
        public Nullable<int> itmId { get; set; }
        public Nullable<int> small { get; set; }
        public Nullable<int> medium { get; set; }
        public Nullable<int> large { get; set; }
        public Nullable<int> xlarge { get; set; }
        public string date { get; set; }
        public string reason { get; set; }
        public Nullable<int> invoice_ { get; set; }
        public Nullable<int> RID { get; set; }
    }
}