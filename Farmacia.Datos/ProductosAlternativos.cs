//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Farmacia.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductosAlternativos
    {
        public int IDProductoAlternativo { get; set; }
        public int IDProducto { get; set; }
        public int IDProductoAlt { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Producto Producto1 { get; set; }
    }
}