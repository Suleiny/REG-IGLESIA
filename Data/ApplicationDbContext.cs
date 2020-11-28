using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IGLESIA.Data
{


    public class ApplicationDbContext : IdentityDbContext<Usuarios>
    {
        public DbSet<Usuarios> UsuariosI { get; set; }

        public DbSet<Miembros> IMiembros { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>(entityTypeBuilder =>
            {
                entityTypeBuilder.ToTable("USUARIOS");
                entityTypeBuilder.Property(u => u.Id_Usuario).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.Nombre_Usuario).HasMaxLength(100);

            });
        }





     

    }


    public class Usuarios : IdentityUser
    {
        public Guid Id_Usuario { get; set; }

        public string Nombre_Usuario { get; set; }

    }


    public class Miembros
    {
        public Guid Id_Usuario { get; set; }

        public Guid Id { get; set; }

        /*DATOS PERSONALES*/
        public string Sexo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaN { get; set; }

        public string PaisOrigen { get; set; }

        public string CiudadOrigen { get; set; }

        public string PaisActual { get; set; }

        public string CiudadActual { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Correo { get; set; }

        public string TipoDocumento { get; set; }

        public string DocumentoIdentidad { get; set; }

        /*DATOS FAMILIARES*/

        public string EstadoCivil { get; set; }

        public string Pareja { get; set; }

        public string Hijos { get; set; }

        public string HijosC { get; set; }

        /*DATOS LABORALES*/

        public string Profesion { get; set; }

        public string Ocupacion { get; set; }

        public string Empresa { get; set; }

        public string TelefonoEmpresa { get; set; }

        /*DATOS ECLESIASTICOS*/

        public DateTime FechaConvertido { get; set; }

        public DateTime FechaBautismo { get; set; }

        public DateTime FechaAceptacion { get; set; }

        public string Denominacion { get; set; }

        public string Iglesia { get; set; }

        public string Tiempo { get; set; }

        public string IglesiaAnterior { get; set; }

        public string Pastor { get; set; }

        public string Disciplina { get; set; }

        public string DiscipilnaN { get; set; }

        public string Causa { get; set; }

        public string Funcion { get; set; }

        public string MinisteriosServido { get; set; }

        public string ExitoM { get; set; }

        public string Don { get; set; }

        public string Vida { get; set; }

        public string Respaldo { get; set; }

        /*DATOS ACADEMICOS*/

        public string NivelEstudio { get; set; }

        public string Expulsion { get; set; }

        public string RazonExpulsion { get; set; }
    }





























}





