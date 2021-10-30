using Entities.POCO;
using Microsoft.EntityFrameworkCore;

namespace Repositories.EntityFrameworkCore.DataContext
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        public DbSet<Promocion> Promocion { get; set; }
        //YR_28102021
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CleanArchExampleDB;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CleanArchExampleDB;User ID=sa;Password=as");
         
        }
        //End_YR
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Promocion>(entity =>
            {
                entity.ToTable("Promocion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);
            });
           
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
