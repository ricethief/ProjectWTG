//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WTGproject.DatabaseEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bodypart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bodypart()
        {
            this.Exercise_bodypart = new HashSet<Exercise_bodypart>();
        }
    
        public int bodypartID { get; set; }
        public string bodypartName { get; set; }
        public decimal MV { get; set; }
        public decimal MEV { get; set; }
        public decimal MAV { get; set; }
        public decimal MRV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercise_bodypart> Exercise_bodypart { get; set; }
    }
}