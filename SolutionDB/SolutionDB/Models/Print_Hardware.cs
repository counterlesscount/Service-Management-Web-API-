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
    
    public partial class Print_Hardware
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Print_Hardware()
        {
            this.Prints = new HashSet<Print>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Solution_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Print> Prints { get; set; }
        public virtual Solution Solution { get; set; }
    }
}
