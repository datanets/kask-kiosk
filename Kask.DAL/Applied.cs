//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kask.DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Applied
    {
        public int Applicant_ID { get; set; }
        public int Application_ID { get; set; }
        public int Job_ID { get; set; }
        public System.DateTime DateApplied { get; set; }
    
        public virtual Applicant Applicant { get; set; }
        public virtual Application Application { get; set; }
        public virtual Job Job { get; set; }
    }
}