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
    
    public partial class tblMessage
    {
        public int Id { get; set; }
        public string message { get; set; }
        public Nullable<System.DateTime> sent_time { get; set; }
        public Nullable<bool> isSent { get; set; }
    }
}