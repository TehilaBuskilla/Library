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
    
    public partial class BorrowedBooks
    {
        public int CodeBorrowedBooks { get; set; }
        public int BookCode { get; set; }
        public string UserId { get; set; }
        public System.DateTime BorrowingDate { get; set; }
        public bool IsBorrowed { get; set; }
    
        public virtual ReadingBooks ReadingBooks { get; set; }
        public virtual Users Users { get; set; }
    }
}
