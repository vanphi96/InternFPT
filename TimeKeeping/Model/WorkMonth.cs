//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkMonth
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkMonth()
        {
            this.WorkDays = new HashSet<WorkDay>();
        }
    
        public int WorkMonthId { get; set; }
        public int SumWork { get; set; }
        public int CeaseCause { get; set; }
        public int CeaseNotCause { get; set; }
        public int Moth { get; set; }
        public int Year { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkDay> WorkDays { get; set; }
    }
}