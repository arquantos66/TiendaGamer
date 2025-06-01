using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Vendedores
    {
        public int id { get; set; }
        public String? nombre { get; set; }
        public String? apellido { get; set; }

        public String? cedula { get; set; }
        public int? edad { get; set; }
        public List<VendedoresProductos>? VendedoresProductos { get; set; }

    }
}
