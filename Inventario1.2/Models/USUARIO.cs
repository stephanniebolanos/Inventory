//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.COMPRA = new HashSet<COMPRA>();
            this.VENTA = new HashSet<VENTA>();
        }
    
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public Nullable<int> IdTienda { get; set; }
        public Nullable<int> IdRol { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual ICollection<COMPRA> COMPRA { get; set; }
        public virtual ROL ROL { get; set; }
        public virtual TIENDA TIENDA { get; set; }
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}
