using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorio.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace lib_aplicaciones.Implementaciones
{
    public class ClientesAplicaciones : IClientesAplicacion
    {
        private IConexion? IConexion = null;
        public ClientesAplicaciones(IConexion iConexion)
        { 
            this.IConexion = iConexion; 
        
        }
        public void Configurar(string StringConexion)
        { 
            this.IConexion!.StringConexion = StringConexion; 
        }

        public Clientes? Borrar(Clientes? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.id == 0) 
                throw new Exception("lbNoSeGuardo");

            this.IConexion!.Clientes!.Remove(entidad);
            this.IConexion.SaveChanges(); 
            return entidad;
        }
        public Clientes? Guardar(Clientes? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.id != 0)
                throw new Exception("lbYaSeGuardo");

            

            this.IConexion!.Clientes!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }
        public List<Clientes> Listar()
        { 
            return this.IConexion!.Clientes!.Take(20).ToList(); 
        }
        public List<Clientes> PorCodigo(Clientes? entidad) 
        { 
            return this.IConexion!.Clientes!
                .Where(x => x.codigo!.Contains(entidad!.codigo!))
                .ToList(); 
        }
        public Clientes? Modificar(Clientes? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.id == 0) 
                throw new Exception("lbNoSeGuardo");

            

            var entry = this.IConexion!.Entry<Clientes>(entidad); 
            entry.State = EntityState.Modified; 
            this.IConexion.SaveChanges(); 
            return entidad;
        }
    }
}
