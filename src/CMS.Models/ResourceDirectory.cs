//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResourceDirectory
    {
        public int Id { get; set; }
        public string DirectoryName { get; set; }
        public Nullable<int> ParentDirectoryId { get; set; }
        public int DepartmentId { get; set; }
    }
}