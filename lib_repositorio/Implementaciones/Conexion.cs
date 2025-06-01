using lib_dominio.Entidades;
using lib_repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorio.Implementaciones
{
    public partial class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<ClientesProductos>? ClientesProductos { get; set; }
        public DbSet<Marcas>? Marcas { get; set; }
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<ProductosMarcas>? ProductosMarcas { get; set; }
        public DbSet<Servicios>? Servicios { get; set; }
        public DbSet<ServiciosProductos>? ServiciosProductos { get; set; }
        public DbSet<Tecnicos>? Tecnicos { get; set; }
        public DbSet<TecnicosProductos>? TecnicosProductos { get; set; }
        public DbSet<Vendedores>? Vendedores { get; set; }
        public DbSet<VendedoresProductos>? VendedoresProductos { get; set; }
    }
}