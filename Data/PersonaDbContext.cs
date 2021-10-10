using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tarea9y10.Data
{
    public class PersonaDbContext : DbContext
{
    
    public PersonaDbContext(DbContextOptions<PersonaDbContext> options)
            : base(options)
    {
    }
    
    public DbSet<Persona> personas { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>().HasData(VerReportes());
        base.OnModelCreating(modelBuilder);
    }
    
    private List<Persona> VerReportes()
    {
        return new List<Persona>
    {
        new Persona { PersonaId = 1, nombre = "Christopher", genero = "Masculino",
         apellido = "Severino", telefonoPer = "829-844-0999", 
         celular = "829-844-0999", correo ="Christopherseverino82@gmail.com", 
         DocuIdentidad = "40230337873260", TipoDocumento = "Cedula", PaisNacimiento = "RD", 
         CiudadNacimiento = "Santo domingo", PaisResidencia = "RD",
         Direccion = "Santo domingo este", EstadoCivil = "Soltero",
         Hijos = "No", Profesion = "Ninguna", NombreEmpresa = "--",
         Ocupacion = "--", TelefonoEmp = "--", Denominacion = "Católica",
         NombreIglesia = "San simon", IglesiaAnterior = "San pablo",
         Disciplinado = "Si", Causas = "Muchas", Funciones = "Diacono",
         Ministerios = "Ministerios de damas", MinisterioMayorFruto = "Ministerios de damas",
         MinisterioLlamado = "Ministerios de damas", Metas = "hechar pa alante",
         Respaldo = "Si", CiudadResidencia = "Santo domingo este",
         NivelEstudio = "Tecnico", ExpulsadoIns = "No", Razon = "--"
         },
    };
    }
    
}
}