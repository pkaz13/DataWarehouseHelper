namespace DataWarehouseHelper.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Occupant")]
    public partial class Occupant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Occupant()
        {
            Accident = new HashSet<Accident>();
        }

        public int Id { get; set; }

        [StringLength(10)]
        public string Sex { get; set; }

        public int? Age { get; set; }

        public bool? IsSeatbeltFasten { get; set; }

        public int? Roleid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accident> Accident { get; set; }

        public virtual Role Role { get; set; }
    }
}
