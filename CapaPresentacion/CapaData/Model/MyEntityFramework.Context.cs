﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacion.CapaData.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bd_blulightEntities : DbContext
    {
        public bd_blulightEntities()
            : base("name=bd_blulightEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria_producto> Categoria_producto { get; set; }
        public virtual DbSet<Categoria_servicio> Categoria_servicio { get; set; }
        public virtual DbSet<Color_producto> Color_producto { get; set; }
        public virtual DbSet<Detalle_factura_producto> Detalle_factura_producto { get; set; }
        public virtual DbSet<Detalle_factura_servicio> Detalle_factura_servicio { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Estado_solicitud_servicio> Estado_solicitud_servicio { get; set; }
        public virtual DbSet<Factura_producto> Factura_producto { get; set; }
        public virtual DbSet<Factura_servicio> Factura_servicio { get; set; }
        public virtual DbSet<Inscripto_jornada> Inscripto_jornada { get; set; }
        public virtual DbSet<Jefe_laboratorio> Jefe_laboratorio { get; set; }
        public virtual DbSet<Jornada> Jornada { get; set; }
        public virtual DbSet<Laboratorio> Laboratorio { get; set; }
        public virtual DbSet<Metodo_de_pago> Metodo_de_pago { get; set; }
        public virtual DbSet<Perfil_de_usuario> Perfil_de_usuario { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Salon_auditorio> Salon_auditorio { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Servicio_laboratorio> Servicio_laboratorio { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
