//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAuthorities
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AuthorityId { get; set; }
    
        public virtual Authorities Authorities { get; set; }
        public virtual Users Users { get; set; }
    }
}
