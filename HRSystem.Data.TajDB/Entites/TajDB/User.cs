//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRSystem.DataTajDB.Entites.TajDB
{
    using global::System;  using global::System.Diagnostics.CodeAnalysis;
    using global::System.Collections.Generic;
    
    public partial class User
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.BlackLists = new HashSet<BlackList>();
            this.BlackLists1 = new HashSet<BlackList>();
            this.BranchesPerms = new HashSet<BranchesPerm>();
            this.PhoneGroups = new HashSet<PhoneGroup>();
            this.SendSms = new HashSet<SendSm>();
            this.SmsMessages = new HashSet<SmsMessage>();
            this.UsersPerms = new HashSet<UsersPerm>();
        }
    
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool NotActive { get; set; }
        public byte AlertTime { get; set; }
        public bool IgnoreAutoSerial { get; set; }
        public Nullable<short> OnlyMenuId { get; set; }
        public bool LogH { get; set; }
        public byte[] SigImg { get; set; }
        public Nullable<DateTime> PasswordChangeDate { get; set; }
        public bool CanDblQuantity { get; set; }
        public string UserImageURL { get; set; }
        public bool SendLongSMS { get; set; }
        public string PassCode { get; set; }
    
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlackList> BlackLists { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlackList> BlackLists1 { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BranchesPerm> BranchesPerms { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhoneGroup> PhoneGroups { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SendSm> SendSms { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SmsMessage> SmsMessages { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersPerm> UsersPerms { get; set; }
    }
}