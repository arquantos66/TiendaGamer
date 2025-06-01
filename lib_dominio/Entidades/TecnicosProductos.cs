using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class TecnicosProductos
    {

        public int id { get; set; }
        public int tecnico { get; set; }
        public int producto { get; set; }

        [ForeignKey("tecnico")]
        public Tecnicos? Tecnico { get; set; }

        [ForeignKey("producto")]
        public Productos? Producto { get; set; }

    }
}
