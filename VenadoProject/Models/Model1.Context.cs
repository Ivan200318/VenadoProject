﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VenadoProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class rinconEntities : DbContext
    {
        public rinconEntities()
            : base("name=rinconEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<clase_producto> clase_producto { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<detalle_factura> detalle_factura { get; set; }
        public virtual DbSet<enc_factura> enc_factura { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<promociones> promociones { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }
        public virtual DbSet<stock> stock { get; set; }
        public virtual DbSet<tipo_transaccion> tipo_transaccion { get; set; }
        public virtual DbSet<tipo_user> tipo_user { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<vfacturas> vfacturas { get; set; }
        public virtual DbSet<vdetalles> vdetalles { get; set; }
    }
}
