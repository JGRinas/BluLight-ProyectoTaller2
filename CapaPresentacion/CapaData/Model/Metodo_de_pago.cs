//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Metodo_de_pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Metodo_de_pago()
        {
            this.Factura_producto = new HashSet<Factura_producto>();
        }
    
        public int idMetodoPago { get; set; }
        public string metodo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura_producto> Factura_producto { get; set; }
    }
}
