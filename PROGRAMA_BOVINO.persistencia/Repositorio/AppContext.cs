using Microsoft.EntityFrameworkCore;
using bovino.dominio;
namespace PROGRAMA_BOVINO.persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Aper_vaca> Aper_Vacas {get;set;}
        public DbSet<Aper_propietario> Aper_Propietarios {get;set;}
        public DbSet<Aper_veterinario> Aper_Veterinarios {get;set;}
        public DbSet<Historia_Clinica> Historias_Clinicas {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
 
   
 
        if(!optionsBuilder.IsConfigured)// configuracion de la base de datos 
 
        {
        optionsBuilder
        .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=CUIDADO_BOVINO");
 
         }
      }


    }
    
}
