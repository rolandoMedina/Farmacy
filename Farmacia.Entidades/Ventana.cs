//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Farmacia.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ventana()
        {
            this.RolVentana = new HashSet<RolVentana>();
            this.Ventana1 = new HashSet<Ventana>();
        }
    
        public int IDVentana { get; set; }
        public Nullable<int> IDVentanaDependencia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolVentana> RolVentana { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventana> Ventana1 { get; set; }
        public virtual Ventana Ventana2 { get; set; }
    }
}
