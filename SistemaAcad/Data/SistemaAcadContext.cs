using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAcad.Models;

namespace SistemaAcad.Models
{
    public class SistemaAcadContext : DbContext
    {
        public SistemaAcadContext (DbContextOptions<SistemaAcadContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaAcad.Models.Asignacion> Asignacion { get; set; }

        public DbSet<SistemaAcad.Models.Categoria> Categoria { get; set; }

        public DbSet<SistemaAcad.Models.Curso> Curso { get; set; }

        public DbSet<SistemaAcad.Models.Estudiante> Estudiante { get; set; }

        public DbSet<SistemaAcad.Models.Instructor> Instructor { get; set; }

        public DbSet<SistemaAcad.Models.Inscripcion> Inscripcion { get; set; }

        public DbSet<SistemaAcad.Models.Persona> Persona { get; set; }
    }
}
