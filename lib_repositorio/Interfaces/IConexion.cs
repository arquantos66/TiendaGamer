using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorio.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Clientes>? Clientes { get; set; }
        DbSet<ClientesProductos>? ClientesProductos { get; set; }
        DbSet<Marcas>? Marcas { get; set; }
        DbSet<Productos>? Productos { get; set; }
        DbSet<ProductosMarcas>? ProductosMarcas { get; set; }
        DbSet<Servicios>? Servicios { get; set; }
        DbSet<ServiciosProductos>? ServiciosProductos { get; set; }
        DbSet<Tecnicos>? Tecnicos { get; set; }
        DbSet<TecnicosProductos>? TecnicosProductos { get; set; }
        DbSet<Vendedores>? Vendedores { get; set; }
        DbSet<VendedoresProductos>? VendedoresProductos { get; set; }


        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
