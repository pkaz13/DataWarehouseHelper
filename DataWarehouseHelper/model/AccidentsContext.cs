namespace DataWarehouseHelper.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AccidentsContext : DbContext
    {
        public AccidentsContext()
            : base("name=AccidentsContext")
        {
        }

        public virtual DbSet<Accident> Accident { get; set; }
        public virtual DbSet<AccidentTrait> AccidentTrait { get; set; }
        public virtual DbSet<Occupant> Occupant { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Time> Time { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Occupant>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);
        }
    }
}
