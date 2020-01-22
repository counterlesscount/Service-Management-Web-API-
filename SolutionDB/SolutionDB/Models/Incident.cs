//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolutionDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incident
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incident()
        {
            this.SecondLevels = new HashSet<SecondLevel>();
        }
    
        public int Id { get; set; }
        public int Caller_Id { get; set; }
        public string Descrition { get; set; }
        public Nullable<int> Category_Id { get; set; }
        public byte[] Opened { get; set; }
        public int Urgency_Id { get; set; }
        public int Status_Id { get; set; }
        public int Solution_Id { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Solution Solution { get; set; }
        public virtual Status Status { get; set; }
        public virtual Urgency Urgency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecondLevel> SecondLevels { get; set; }
    }
}