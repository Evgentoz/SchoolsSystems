//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace schoolsSystems.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string NewsText { get; set; }
        public string HeadText { get; set; }
    
        public virtual School School { get; set; }
    }
}
