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
    
    public partial class MENU
    {
        public MENU()
        {
            this.SUBMENU = new HashSet<SUBMENU>();
        }
    
        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public string Icono { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual ICollection<SUBMENU> SUBMENU { get; set; }
    }
}
