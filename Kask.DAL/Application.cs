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
    
    public partial class Application
    {
        public Application()
        {
            this.Applieds = new HashSet<Applied>();
        }
    
        public int Application_ID { get; set; }
        public string ApplicationStatus { get; set; }
        public virtual ICollection<Applied> Applieds { get; set; }
    }
}
