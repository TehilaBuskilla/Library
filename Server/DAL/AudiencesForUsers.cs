//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AudiencesForUsers
    {
        public int CodeAudiencesForUsers { get; set; }
        public int AudienceCode { get; set; }
        public string UserId { get; set; }
    
        public virtual Audiences Audiences { get; set; }
        public virtual Users Users { get; set; }
    }
}
