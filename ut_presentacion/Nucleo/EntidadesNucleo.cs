using lib_dominio.Entidades;
namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Clientes? Clientes()
        {
            var EntidadCl = new Clientes();
            EntidadCl.codigo = "P" + new Random().Next(1000, 9999);
            EntidadCl.nombre = "Pruebas";
            EntidadCl.apellido = "Pruebas";
            EntidadCl.direccion = "Pruebas";
            EntidadCl.email = "Pruebas";

            return EntidadCl;
        }

        public static ClientesProductos? ClientesProductos()
        {
            var EntidadClp = new ClientesProductos();
            EntidadClp.cliente = 1;
            EntidadClp.producto = 1;

            return EntidadClp;
        }

        public static Marcas? Marcas()
        {
            var EntidadMar = new Marcas();
            EntidadMar.nombre = "Pruebas";

            return EntidadMar;
        }
        public static Productos? Productos()
        {
            var EntidadPro = new Productos();
            EntidadPro.codigo = "P" + new Random().Next(1000, 9999);
            EntidadPro.nombre = "Pruebas";
            EntidadPro.precio = 50100m;
            EntidadPro.iva = 0.19m;
            EntidadPro.garantia = "Pruebas";

            return EntidadPro;
        }
        public static ProductosMarcas? ProductosMarcas()
        {
            var EntidadProM = new ProductosMarcas();
            EntidadProM.marca = 1;
            EntidadProM.producto = 1;

            return EntidadProM;
        }
        public static Servicios? Servicios()
        {
            var EntidadSer = new Servicios();
            EntidadSer.nombre = "Pruebas";

            return EntidadSer;
        }
        public static ServiciosProductos? ServiciosProductos()
        {
            var EntidadSerP = new ServiciosProductos();
            EntidadSerP.servicio = 1;
            EntidadSerP.producto = 1;

            return EntidadSerP;
        }
        public static Tecnicos? Tecnicos ()
        {
            var EntidadTec = new Tecnicos();
            EntidadTec.nombre = "Pruebas";
            EntidadTec.apellido = "Pruebas";
            EntidadTec.cedula = "Pruebas";
            EntidadTec.edad = 20;

            return EntidadTec;
        }
        public static TecnicosProductos? TecnicosProductos()
        {
            var EntidadTecP = new TecnicosProductos();
            EntidadTecP.tecnico = 1;
            EntidadTecP.producto = 1;

            return EntidadTecP;
        }
        public static Vendedores? Vendedores()
        {
            var EntidadVen = new Vendedores();
            EntidadVen.nombre = "Pruebas";
            EntidadVen.apellido = "Pruebas";
            EntidadVen.cedula = "Pruebas";
            EntidadVen.edad = 20;

            return EntidadVen;
        }
        public static VendedoresProductos? VendedoresProductos()
        {
            var EntidadVenP = new VendedoresProductos();
            EntidadVenP.vendedor = 1;
            EntidadVenP.producto = 1;

            return EntidadVenP;
        }
    }
}
