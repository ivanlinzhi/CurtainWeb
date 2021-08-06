using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Curtain.Data
{
    public partial class CurtainContext : DbContext
    {
        public CurtainContext()
        {
        }

        public CurtainContext(DbContextOptions<CurtainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Inventory> Inventories { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=localhost;Database=Curtain;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inventory");

                entity.Property(e => e.Amount).HasMaxLength(255);

                entity.Property(e => e.Available).HasMaxLength(255);

                entity.Property(e => e.Balance).HasMaxLength(255);

                entity.Property(e => e.CodeNumber).HasMaxLength(255);

                entity.Property(e => e.Color).HasMaxLength(255);

                entity.Property(e => e.CurtainPartsDeductioncm).HasMaxLength(255);

                entity.Property(e => e.CurtainPartsDeductionin).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Diametercm).HasMaxLength(255);

                entity.Property(e => e.Diameterin).HasMaxLength(255);

                entity.Property(e => e.DiameterinF).HasMaxLength(255);

                entity.Property(e => e.Feature).HasMaxLength(255);

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InventoryDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryNumber).HasMaxLength(255);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(255)
                    .HasColumnName("ItemID");

                entity.Property(e => e.ItemName).HasMaxLength(255);

                entity.Property(e => e.LengthinF).HasMaxLength(255);

                entity.Property(e => e.Locatedat).HasMaxLength(255);

                entity.Property(e => e.Made).HasMaxLength(255);

                entity.Property(e => e.Material).HasMaxLength(255);

                entity.Property(e => e.Motor).HasMaxLength(255);

                entity.Property(e => e.Partscm).HasMaxLength(255);

                entity.Property(e => e.Partsin).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.PurchasedQuantity).HasMaxLength(255);

                entity.Property(e => e.PurchasedUnit).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.Style).HasMaxLength(255);

                entity.Property(e => e.Supplier).HasMaxLength(255);

                entity.Property(e => e.Tax).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);

                entity.Property(e => e.UnitPrice).HasMaxLength(255);

                entity.Property(e => e.UsedFor).HasMaxLength(255);

                entity.Property(e => e.UsedProductionId)
                    .HasMaxLength(255)
                    .HasColumnName("UsedProductionID");

                entity.Property(e => e.UseforAurora).HasMaxLength(255);

                entity.Property(e => e.UseforBlackOut).HasMaxLength(255);

                entity.Property(e => e.UseforCassete).HasMaxLength(255);

                entity.Property(e => e.UseforRollerShade).HasMaxLength(255);

                entity.Property(e => e.UseforZebra).HasMaxLength(255);

                entity.Property(e => e.WidthinF).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
