﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario1._2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CATEGORIA> CATEGORIA { get; set; }
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<COMPRA> COMPRA { get; set; }
        public DbSet<DETALLE_COMPRA> DETALLE_COMPRA { get; set; }
        public DbSet<DETALLE_VENTA> DETALLE_VENTA { get; set; }
        public DbSet<MENU> MENU { get; set; }
        public DbSet<PERMISOS> PERMISOS { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<PRODUCTO_TIENDA> PRODUCTO_TIENDA { get; set; }
        public DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public DbSet<ROL> ROL { get; set; }
        public DbSet<SUBMENU> SUBMENU { get; set; }
        public DbSet<TIENDA> TIENDA { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<VENTA> VENTA { get; set; }
    }
}
