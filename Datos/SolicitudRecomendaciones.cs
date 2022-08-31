//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class SolicitudRecomendaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudRecomendaciones()
        {
            this.DenunciasSolicitudRecomendaciones = new HashSet<DenunciasSolicitudRecomendaciones>();
            this.Recomendaciones = new HashSet<Recomendaciones>();
        }
    
        public int id { get; set; }
        public string titulo { get; set; }
        public string leyenda { get; set; }
        public int id_usuario { get; set; }
        public Nullable<int> visitas { get; set; }
        public bool eliminado { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int reputacion_otorgada { get; set; }
        public bool sin_skill { get; set; }
        public bool skill_prisa { get; set; }
        public bool skill_destacado { get; set; }
        public Nullable<int> nivel_requerido { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DenunciasSolicitudRecomendaciones> DenunciasSolicitudRecomendaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recomendaciones> Recomendaciones { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}