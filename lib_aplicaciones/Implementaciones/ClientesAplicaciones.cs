using lib_aplicaciones.Interfaces;
using lib_dominio.Entidades;
using lib_repositorio.Interfaces;

using Microsoft.EntityFrameworkCore;
namespace lib_aplicaciones.Implementaciones
{
    public class NotasAplicacion : INotasAplicacion
    {
        private IConexion? IConexion = null;
        public NotasAplicacion(IConexion iConexion)
        { this.IConexion = iConexion; }
        public void Configurar(string StringConexion) { this.IConexion!.StringConexion = StringConexion; }
        public Notas? Borrar(Notas? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad!.Id == 0) throw new Exception("lbNoSeGuardo");
            this.IConexion!.Notas!.Remove(entidad); this.IConexion.SaveChanges(); return entidad;
        }
        public Notas? Guardar(Notas? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0) throw new Exception("lbYaSeGuardo");
            entidad!.NotaFinal = (entidad.Nota1 + entidad.Nota2 + entidad.Nota3 + entidad.Nota4 + entidad.Nota5) / 5;
            this.IConexion!.Notas!.Add(entidad); this.IConexion.SaveChanges(); return entidad;
        }
        public List<Notas> Listar() { return this.IConexion!.Notas!.Take(20).ToList(); }
        public List<Notas> PorEstudiante(Notas? entidad) { return this.IConexion!.Notas!.Where(x => x.Estudiante!.Contains(entidad!.Estudiante!)).ToList(); }
        public Notas? Modificar(Notas? entidad)
        {
            if (entidad == null) throw new Exception("lbFaltaInformacion");
            if (entidad!.Id == 0) throw new Exception("lbNoSeGuardo");
            entidad!.NotaFinal = (entidad.Nota1 + entidad.Nota2 + entidad.Nota3 + entidad.Nota4 + entidad.Nota5) / 5;
            var entry = this.IConexion!.Entry<Notas>(entidad); entry.State = EntityState.Modified; this.IConexion.SaveChanges(); return entidad;
        }
    }
}
Lógica