using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Servicios
    {

        public int id { get; set; }
        public String? nombre { get; set; }
        public List<ServiciosProductos>? ServiciosProductos { get; set; }

    }
}
