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
    
    public partial class Factura_producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura_producto()
        {
            this.Detalle_factura_producto = new HashSet<Detalle_factura_producto>();
        }
    
        public int idFacturaProd { get; set; }
        public int idMetodoPago { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan hora { get; set; }
        public Nullable<int> idPersona { get; set; }
        public Nullable<bool> activo { get; set; }
        public Nullable<int> idEmpleado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_factura_producto> Detalle_factura_producto { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Metodo_de_pago Metodo_de_pago { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
