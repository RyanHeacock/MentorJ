//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloWorldWcfHost
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInfo
    {
        public long ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Sex { get; set; }
        public string Street_Address { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public Nullable<bool> isPremium { get; set; }
        public Nullable<bool> isMentor { get; set; }
        public Nullable<bool> isAdmin { get; set; }
        public System.DateTime LastLogin { get; set; }
        public byte[] LastActive { get; set; }
        public System.DateTime AccountDateCreated { get; set; }
    }
}
