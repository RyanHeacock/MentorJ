//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MentorJWcfService
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblForum
    {
        public long ForumID { get; set; }
        public string Name { get; set; }
        public string WebForumLink { get; set; }
        public string Forum_Description { get; set; }
        public byte[] LargePicture { get; set; }
        public byte[] MediumPicture { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
    }
}