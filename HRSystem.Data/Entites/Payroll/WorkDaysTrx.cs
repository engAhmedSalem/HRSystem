//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRSystem.Data.Entites.Payroll
{
    using global::System;  using global::System.Diagnostics.CodeAnalysis;
    using global::System.Collections.Generic;
    
    public partial class WorkDaysTrx
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkDaysTrx()
        {
            this.WorkDays = new HashSet<WorkDay>();
            this.WorkDaysTrxEmps = new HashSet<WorkDaysTrxEmp>();
        }
    
        public short Year { get; set; }
        public short Serial { get; set; }
        public DateTime FromDate { get; set; }
        public string FromDateH { get; set; }
        public DateTime ToDate { get; set; }
        public string ToDateH { get; set; }
        public string Notes { get; set; }
    
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkDay> WorkDays { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkDaysTrxEmp> WorkDaysTrxEmps { get; set; }
    }
}