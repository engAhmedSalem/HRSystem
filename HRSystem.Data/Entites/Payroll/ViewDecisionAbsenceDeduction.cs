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
    
    public partial class ViewDecisionAbsenceDeduction
    {
        public int DecisionAbsenceDeductionID { get; set; }
        public string Serial { get; set; }
        public string DateH { get; set; }
        public byte EnclosureCount { get; set; }
        public string OwnerName { get; set; }
        public string DepartmentName { get; set; }
        public string LetterId { get; set; }
        public string LetterDateH { get; set; }
        public short EmpCount { get; set; }
    }
}