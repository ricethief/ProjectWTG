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
    
    public partial class Exercise_category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exercise_category()
        {
            this.Exercises = new HashSet<Exercis>();
        }
    
        public string exercise_categoryID { get; set; }
        public string categoryName { get; set; }
        public string categoryType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercis> Exercises { get; set; }
    }
}
