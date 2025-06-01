using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class ProductosMarcas
    {

        public int id { get; set; }
        public int marca { get; set; }
        public int producto { get; set; }

        [ForeignKey("marca")]
        public Marcas? Marca { get; set; }

        [ForeignKey("producto")]
        public Productos? Producto { get; set; }

    }
}
