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
    
    public partial class LoansMonth
    {
        public int EmpID { get; set; }
        public int Serial { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public decimal Amount { get; set; }
        public short Loans_Count { get; set; }
        public Nullable<long> InstallmentNo { get; set; }
        public string LoanDate { get; set; }
        public Nullable<DateTime> Date { get; set; }
    }
}