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
    
    public partial class DecisionEndService_ROW_NUMBER
    {
        public string EndServiceYear { get; set; }
        public Nullable<long> EndServiceSerial { get; set; }
        public int DecisionEndServiceID { get; set; }
        public DateTime Date { get; set; }
        public string DateH { get; set; }
        public Nullable<byte> EnclosureCount { get; set; }
        public int Owner { get; set; }
        public int EmpId { get; set; }
        public string DependOn { get; set; }
        public string Reason { get; set; }
        public string SystemDeserved { get; set; }
        public DateTime EndWorkDate { get; set; }
        public string EndWorkDateH { get; set; }
    }
}