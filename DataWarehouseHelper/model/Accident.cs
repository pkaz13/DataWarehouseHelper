namespace DataWarehouseHelper.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accident")]
    public partial class Accident
    {
        public int Id { get; set; }

        public int? TimeId { get; set; }

        public int? OccupantId { get; set; }

        public int? VehicleId { get; set; }

        public int? AccidentTraitId { get; set; }

        public int? QuantityOfAccidents { get; set; }

        public virtual AccidentTrait AccidentTrait { get; set; }

        public virtual Occupant Occupant { get; set; }

        public virtual Time Time { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
