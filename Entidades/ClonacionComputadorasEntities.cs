namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClonacionComputadorasEntities : DbContext
    {
        public ClonacionComputadorasEntities()
            : base("name=ClonacionComputadorasEntities1")
        {
        }

        public virtual DbSet<Computadoras> Computadoras { get; set; }
        public virtual DbSet<computadora> computadora { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
