//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SicossDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class opeUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public opeUsuario()
        {
            this.opeHistorialSuperDigito = new HashSet<opeHistorialSuperDigito>();
        }
    
        public int Id { get; set; }
        public string cUsuario { get; set; }
        public string cPassword { get; set; }
        public System.DateTime dtFechaRegistro { get; set; }
        public Nullable<System.DateTime> dtFechaActualiza { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<opeHistorialSuperDigito> opeHistorialSuperDigito { get; set; }
    }
}
