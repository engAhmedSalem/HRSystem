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
    
    public partial class VacationTransferDEmp
    {
        public int VTDSerial { get; set; }
        public int EmpId { get; set; }
        public decimal Days { get; set; }
        public string Notes { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual VacationTransferD VacationTransferD { get; set; }
    }
}