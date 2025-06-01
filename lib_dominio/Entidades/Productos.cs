using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Productos
    {

        public int id { get; set; }
        public String? codigo { get; set; }
        public String? nombre { get; set; }
        public decimal? iva { get; set; }
        public String? garantia { get; set; }
        public List<VendedoresProductos>? VendedoresProductos { get; set; }
        public List<TecnicosProductos>? TecnicosProductos { get; set; }
        public List<ClientesProductos>? ClientesProductos { get; set; }
        public List<ServiciosProductos>? ServiciosProductos { get; set; }
        public List<ProductosMarcas>? ProductosMarcas { get; set; }

    }
}
