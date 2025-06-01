using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class VendedoresProductos
    {

        public int id { get; set; }
        public int vendedor { get; set; }
        public int producto { get; set; }

        [ForeignKey("vendedor")]
        public Vendedores? Vendedor { get; set; }

        [ForeignKey("producto")]
        public Productos? Producto { get; set; }

    }
}
