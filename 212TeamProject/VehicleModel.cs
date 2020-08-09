namespace _212TeamProject
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VehicleModel : DbContext
    {
        public VehicleModel()
            : base("name=VehicleModel")
        {
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehicleIdNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.PlateNum)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Make)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Color)
                .IsUnicode(false);
        }
    }
}
