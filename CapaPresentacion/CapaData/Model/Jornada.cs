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
    
    public partial class Jornada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jornada()
        {
            this.Inscripto_jornada = new HashSet<Inscripto_jornada>();
        }
    
        public int idJornada { get; set; }
        public string nombre { get; set; }
        public Nullable<int> cupo { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan hora { get; set; }
        public int idJefeLab { get; set; }
        public int idAuditorio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscripto_jornada> Inscripto_jornada { get; set; }
        public virtual Jefe_laboratorio Jefe_laboratorio { get; set; }
        public virtual Salon_auditorio Salon_auditorio { get; set; }
    }
}
