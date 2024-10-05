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
    
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.DETALLE_COMPRA = new HashSet<DETALLE_COMPRA>();
            this.DETALLE_VENTA = new HashSet<DETALLE_VENTA>();
            this.PRODUCTO_TIENDA = new HashSet<PRODUCTO_TIENDA>();
        }
    
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public Nullable<int> ValorCodigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual ICollection<DETALLE_COMPRA> DETALLE_COMPRA { get; set; }
        public virtual ICollection<DETALLE_VENTA> DETALLE_VENTA { get; set; }
        public virtual ICollection<PRODUCTO_TIENDA> PRODUCTO_TIENDA { get; set; }
    }
}
