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
    
    public partial class TrainingDetail
    {
        public string exerciseType { get; set; }
        public string exerciseDate { get; set; }
        public int exerciseID { get; set; }
        public int trainingId { get; set; }
    
        public virtual Exercis Exercis { get; set; }
        public virtual Training Training { get; set; }
    }
}
