//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusForUsers
    {
        public long CodeStatusForUsers { get; set; }
        public Nullable<long> StatusCode { get; set; }
        public Nullable<long> UserId { get; set; }
    
        public virtual StatusUser StatusUser { get; set; }
        public virtual Users Users { get; set; }
    }
}
