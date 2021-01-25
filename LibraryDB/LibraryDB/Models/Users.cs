//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.AudiencesForUsers = new HashSet<AudiencesForUsers>();
            this.AuthorsForUsers = new HashSet<AuthorsForUsers>();
            this.BorrowedBooks = new HashSet<BorrowedBooks>();
            this.KindsOfBooksForUsers = new HashSet<KindsOfBooksForUsers>();
            this.StatusForUsers = new HashSet<StatusForUsers>();
        }
    
        public long IdUser { get; set; }
        public string NameUser { get; set; }
        public int AgeUser { get; set; }
        public Nullable<long> GenderCode { get; set; }
        public Nullable<long> StatusCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AudiencesForUsers> AudiencesForUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuthorsForUsers> AuthorsForUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowedBooks> BorrowedBooks { get; set; }
        public virtual Genders Genders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KindsOfBooksForUsers> KindsOfBooksForUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatusForUsers> StatusForUsers { get; set; }
        public virtual StatusUser StatusUser { get; set; }
    }
}
