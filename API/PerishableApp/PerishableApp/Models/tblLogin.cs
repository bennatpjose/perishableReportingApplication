//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerishableApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLogin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public Nullable<int> fk_CompanyID { get; set; }
        public Nullable<int> fk_CharityID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    
        public virtual tblCharity tblCharity { get; set; }
        public virtual tblCompany tblCompany { get; set; }
    }
}