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
    
    public partial class Detalle_factura_servicio
    {
        public int idFacturaServ { get; set; }
        public int idServicio { get; set; }
        public int idEstado { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
    
        public virtual Factura_servicio Factura_servicio { get; set; }
    }
}
