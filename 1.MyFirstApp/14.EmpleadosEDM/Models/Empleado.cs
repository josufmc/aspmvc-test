//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _14.EmpleadosEDM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Empleado_Detalles = new HashSet<Empleado_Detalles>();
            this.Empleado_Experiencia_Estadisticas = new HashSet<Empleado_Experiencia_Estadisticas>();
            this.Empleados_Antiguedad_Estadisticas = new HashSet<Empleados_Antiguedad_Estadisticas>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> ANTIGUEDAD { get; set; }
        public Nullable<int> Edad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado_Detalles> Empleado_Detalles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado_Experiencia_Estadisticas> Empleado_Experiencia_Estadisticas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados_Antiguedad_Estadisticas> Empleados_Antiguedad_Estadisticas { get; set; }
    }
}
