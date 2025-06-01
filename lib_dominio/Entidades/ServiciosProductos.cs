using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class ServiciosProductos
    {

        public int id { get; set; }
        public int servicio { get; set; }
        public int producto { get; set; }

        [ForeignKey("servicio")]
        public Servicios? Servicio { get; set; }

        [ForeignKey("producto")]
        public Productos? Producto { get; set; }

    }
}
