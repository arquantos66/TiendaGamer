using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Clientes
    {

        public int id { get; set; }
        public String? codigo { get; set; }
        public String? nombre { get; set; }
        public String? apellido { get; set; }

        public String? direccion { get; set; }
        public String? email { get; set; }
        public List<ClientesProductos>? ClientesProductos { get; set; }


    }
}
