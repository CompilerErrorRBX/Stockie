//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stockie.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubscriptionTerm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubscriptionTerm()
        {
            this.UserSubscriptions = new HashSet<UserSubscription>();
        }
    
        public string Id { get; set; }
        public string SubscriptionIdFK { get; set; }
        public int TermDays { get; set; }
    
        public virtual Subscription Subscription { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}
