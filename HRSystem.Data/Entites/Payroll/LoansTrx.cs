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
    
    public partial class LoansTrx
    {
        public int EmpID { get; set; }
        public int Serial { get; set; }
        public byte LoanID { get; set; }
        public decimal Loan { get; set; }
        public DateTime EndDate { get; set; }
        public string EndDateH { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public string StartDateH { get; set; }
        public short LoansNo { get; set; }
        public string LoanNumber { get; set; }
        public string Notes { get; set; }
        public Nullable<short> CityId { get; set; }
        public bool Stopped { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Loan Loan1 { get; set; }
    }
}