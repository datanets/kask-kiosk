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
    
    public partial class Applicant
    {
        public Applicant()
        {
            this.Applieds = new HashSet<Applied>();
            this.Schools = new HashSet<School>();
            this.Skills = new HashSet<Skill>();
            this.Employers = new HashSet<Employer>();
        }
    
        public int Applicant_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }
    
        public virtual ICollection<Applied> Applieds { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Employer> Employers { get; set; }
    }
}