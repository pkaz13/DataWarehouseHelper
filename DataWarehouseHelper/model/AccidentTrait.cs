namespace DataWarehouseHelper.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccidentTrait")]
    public partial class AccidentTrait
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccidentTrait()
        {
            Accident = new HashSet<Accident>();
        }

        public int Id { get; set; }

        public int? InjurySeverity { get; set; }

        public bool? AirbagDeploy { get; set; }

        public bool? IsOccupantDead { get; set; }

        public bool? IsAccidentFrontal { get; set; }

        public int? ImpactSpeedFrom { get; set; }

        public int? ImpactSpeedTo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accident> Accident { get; set; }
    }
}
